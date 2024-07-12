<?php

namespace App\Services\LogsService;

use App\Models\BotLog;
use App\Models\User;
use Illuminate\Contracts\Auth\Authenticatable;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Http\Request;

class LogsFilter
{
    protected ?string $botId = null;

    protected ?string $application = null;

    protected ?string $type = null;

    protected ?string $searchQuery = null;

    protected ?string $searchApplication = null;

    protected ?string $sortBy = null;

    protected ?string $sortField = null;

    protected ?string $keyLoggerAction = null;

    protected int $perPage = 15;

    protected User|Authenticatable|null $user;

    public function __construct()
    {
    }

    public function setBotId(string|null $botId): void
    {
        $this->botId = $botId;
    }

    public function setApplication(string|null $application): void
    {
        $this->application = $application;
    }

    public function setType(string|null $type): void
    {
        $this->type = $type;
    }

    public function setUser(User|Authenticatable|null $user): void
    {
        $this->user = $user;
    }

    public function setSearchQuery(string|null $searchQuery): void
    {
        $this->searchQuery = $searchQuery;
    }

    public function setSearchApplication(string|null $searchApplication): void
    {
        $this->searchApplication = $searchApplication;
    }

    public function setSortBy(string|null $sortBy): void
    {
        $this->sortBy = $sortBy;
    }

    public function setSortField(string|null $sortField): void
    {
        $this->sortField = $sortField;
    }

    public function setPerPage(int $perPage): void
    {
        $this->perPage = $perPage;
    }

    public function setKeyLoggerAction(string $keyLoggerAction): void
    {
        $this->keyLoggerAction = $keyLoggerAction;
    }

    public function getBotId(): ?string
    {
        return $this->botId;
    }

    public function getApplication(): ?string
    {
        return $this->application;
    }

    public function getType(): ?string
    {
        return $this->type;
    }

    public function getUser(): User|Authenticatable|null
    {
        return $this->user;
    }

    public function getSearchQuery(): string|null
    {
        return $this->searchQuery;
    }

    public function getSearchApplication(): string|null
    {
        return $this->searchApplication;
    }

    public function getSortBy(): string|null
    {
        return $this->sortBy;
    }

    public function getSortField(): string|null
    {
        return $this->sortField;
    }

    public function getPerPage(): int
    {
        return $this->perPage;
    }

    public function getKeyLoggerAction(): ?string
    {
        return $this->keyLoggerAction;
    }

    public static function fromRequest(Request $request): self
    {
        $filter = new LogsFilter;

        if ($request->get("bot_id")) {
            $filter->setBotId((string)$request->get("bot_id"));
        }

        if ($request->get("application")) {
            $filter->setApplication((string)$request->get("application"));
        }

        if ($request->get("type")) {
            $filter->setType((string)$request->get("type"));
        }

        if (!empty($request->get("filters")["application"])) {
            $filter->setSearchApplication($request->get("filters")["application"]);
        }

        if (!empty($request->get("filters")["query"])) {
            $filter->setSearchQuery($request->get("filters")["query"]);
        }

        if (!empty($request->get("sort")["by"])) {
            $filter->setSortBy($request->get("sort")["by"]);
        }

        if (!empty($request->get("sort")["field"])) {
            $filter->setSortField($request->get("sort")["field"]);
        }

        if (!empty($request->get("per_page"))) {
            $filter->setPerPage($request->get("per_page"));
        }

        if ($request->get("type") === "keylogger" && !empty($request->get("keyloggerAction"))) {
            $filter->setKeyLoggerAction($request->get("keyloggerAction"));
        }

        return $filter;
    }

    public function getLogsQuery(): Builder|BotLog
    {
        $logs = BotLog::query();

        $logs = $logs->join("bots", "bot_logs.bot_id", "=", "bots.id")
            ->select("bot_logs.*");

        if ($this->user->role !== "root" || count($this->user->tagsNames)) {
            $logs->whereIn("bots.tag", $this->user->tagsNames);
        }

        if ($this->botId) {
            $logs->where("bot_id", $this->botId);
        }

        if ($this->application) {
            $logs->where("application", $this->application);
        }

        if ($this->type && $this->type !== "application") {
            $logs->where("type", $this->type);
        }

        return $logs;
    }
}
