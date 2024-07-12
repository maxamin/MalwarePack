---
id: dictionary
title: Dictionary
---
## Справочник.  Статусы платежа

| Значение     | Статус                                   |
|--------------|------------------------------------------|
| ON-PAYMENT   | Платеж исполняется                       |
| NEW          | Платеж создан, ожидается ввод реквизитов |
| APPROVED     | Платеж успешен                           |
| DECLINED     | Платеж отклонен                          |
| REFUNDINPROC | В процессе возврата                      |
| REFUNDED     | Возвращен                                |
| EXPIRED      | Платеж просрочен                         |
| WAITING-AUTH | Ожидает подтверждение авторизации        |
| 3ds          | Требует проверки 3D-Secure               |

## Справочник. Коды ответов

| Код  | Расшифровка                                                                                                                                                  | Расшифровка (ENG)                                                       |
|------|--------------------------------------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------|
| 1    | ОПЕРАЦИЯ РАЗРЕШЕНА                                                                                                                                           |                                                                         |
| 50   | Финансовая транзакция не выполнена                                                                                                                           | General                                                                 |
| 51   | Карта клиента просрочена                                                                                                                                     | Expired card                                                            |
| 52   | Превышено число попыток ввода PIN                                                                                                                            | Number of PIN tries exceeded                                            |
| 53   | Не удалось маршрутизировать транзакцию                                                                                                                       | No sharing allowed                                                      |
| 55   | Транзакция имеет некорректные атрибуты или данная операция не разрешена                                                                                      | Invalid transaction                                                     |
| 56   | Запрашиваемая операция не поддерживается хостом                                                                                                              | Transaction not supported by institution                                |
| 57   | Карта клиента имеет статус 'потеряна' или 'украдена'                                                                                                         | Lost or stolen card                                                     |
| 58   | Карта клиента имеет неправильный статус                                                                                                                      | Invalid card status                                                     |
| 59   | Карта клиента имеет ограниченные возможности                                                                                                                 | Restricted status                                                       |
| 60   | Не найден вендор с указанным номером счета                                                                                                                   | Account not found                                                       |
| 61   | Неверное количество информационных полей для заданного вендора                                                                                               | Wrong customer information for payment                                  |
| 62   | Неверный формат информационного поля платежа                                                                                                                 | Customer information format error                                       |
| 63   | Не найден prepaid-код                                                                                                                                        | Prepaid Code not found                                                  |
| 64   | Track2 карты клиента содержит неверную информацию                                                                                                            | Bad track information Track2                                            |
| 69   | Неверный формат сообщения                                                                                                                                    | Bad message edit                                                        |
| 74   | Невозможно авторизовать                                                                                                                                      | Unable to authorize                                                     |
| 75   | Неверный PAN карты                                                                                                                                           | Invalid credit PAN                                                      |
| 76   | На счете не хватает средств                                                                                                                                  | Insufficient funds                                                      |
| 78   | Произошло дублирование транзакции                                                                                                                            | Duplicate transaction received                                          |
| 82   | Превышение количества использований карты клиента                                                                                                            | Maximum number of times used                                            |
| 85   | Невозможно выдать баланс                                                                                                                                     | Balance not allowed                                                     |
| 95   | Превышение лимита по сумме                                                                                                                                   | Amount over maximum                                                     |
| 100  | Невозможно провести транзакцию                                                                                                                               | Unable to process                                                       |
| 101  | Невозможно авторизовать – необходимо позвонить издателю карты                                                                                                | Unable to authorize – call issuer                                       |
| 105  | Данный тип карт не поддерживается                                                                                                                            | Card not supported                                                      |
| 200  | Неправильный счет клиента                                                                                                                                    | Invalid account                                                         |
| 201  | Неправильный PIN                                                                                                                                             | Incorrect PIN                                                           |
| 205  | Некорректная сумма                                                                                                                                           | Invalid advance amount                                                  |
| 209  | Неверный код транзакции                                                                                                                                      | Invalid transaction code                                                |
| 210  | Неверное значение CAVV                                                                                                                                       | Bad CAVV                                                                |
| 211  | Неверное значение CVV2                                                                                                                                       | Bad Cvv2                                                                |
| 212  | Не найдена оригинальная транзакция для слипа                                                                                                                 | Original transaction not found for slip                                 |
| 213  | Слип принимается повторно                                                                                                                                    | Slip already received                                                   |
| 501  | Транзакция выполнена успешно                                                                                                                                 | Approved                                                                |
| 502  | Транзакция выполнена успешно на частичную сумму                                                                                                              | Partially approved                                                      |
| 503  | Транзакция выполнена успешно только на сумму покупки (для транзакции 118 – Purchase with Cashback)                                                           | Purchase only approved                                                  |
| 510  | Нет номера счета в запросе транзакции, есть несколько счетов указанного типа, и терминал поддерживает выбор счета                                            | Should select account number                                            |
| 511  | Необходимо сменить PVV (разрешена только транзакция PIN Change)                                                                                              | Should change PVV                                                       |
| 512  | Необходимо подтвердить результаты проверки платежа в системе online-приема платежей                                                                          | Confirm Payment Precheck                                                |
| 513  | Транзакция запроса списка уведомлений выполнена успешно                                                                                                      | Select Bill                                                             |
| 514  | Необходимо подтвердить результаты предпроверки операции                                                                                                      | Customer confirmation requested                                         |
| 515  | Не найдена оригинальная транзакция                                                                                                                           | Original transaction not found                                          |
| 516  | Слип уже принят                                                                                                                                              | Slip already received                                                   |
| 517  | Ошибка в реквизитах платежа                                                                                                                                  | Personal information input error                                        |
| 520  | Невозможно захватить Prepaid-код                                                                                                                             | Prepaid code not found                                                  |
| 521  | Баланс корр. счета исчерпан                                                                                                                                  | Corresponding account exhausted                                         |
| 522  | Превышен эквайринговый лимит                                                                                                                                 | Acquirer limit exceeded                                                 |
| 524  | Истек срок действия диамического PVV                                                                                                                         | Dynamic PVV Expired                                                     |
| 525  | Слабый PIN                                                                                                                                                   | Weak PIN                                                                |
| 540  | Карта потеряна                                                                                                                                               | Lost card                                                               |
| 541  | Карта украдена                                                                                                                                               | Stolen card                                                             |
| 549  | Недопустимый тип платежа для данного вендора                                                                                                                 | Ineligible vendor account                                               |
| 550  | Несанкционированное использование                                                                                                                            | Unauthorized usage                                                      |
| 551  | Истек срок действия карты                                                                                                                                    | Expired card                                                            |
| 552  | Неверная карта                                                                                                                                               | Invalid card                                                            |
| 553  | Неверный PIN-код                                                                                                                                             | Invalid PIN                                                             |
| 554  | Системная ошибка                                                                                                                                             | System error                                                            |
| 555  | Неподходящая транзакция                                                                                                                                      | Ineligible transaction                                                  |
| 556  | Неподходящий счет                                                                                                                                            | Ineligible account                                                      |
| 557  | Транзакция не поддерживается                                                                                                                                 | Transaction not supported                                               |
| 558  | Карта ограничена (данная операция по карте не разрешена)                                                                                                     | Restricted Card                                                         |
| 559  | Недостаточно средств на счете                                                                                                                                | Insufficient funds                                                      |
| 560  | Превышен лимит на число использований карты                                                                                                                  | Uses limit exceeded                                                     |
| 561  | Лимит на снятие наличных будет превышен                                                                                                                      | Withdrawal limit would be exceeded                                      |
| 562  | Достигнут или превышен лимит на число неверных вводов PIN-кода                                                                                               | PIN tries limit was reached                                             |
| 563  | Достигнут лимит на снятие наличных                                                                                                                           | Withdrawal limit already reached                                        |
| 564  | Достигнут лимит на депозит                                                                                                                                   | Credit amount limit                                                     |
| 565  | Нет информации для предоставления отчета по счету                                                                                                            | No statement information                                                |
| 566  | Предоставление отчета по счету невозможно (запрещено)                                                                                                        | Statement not available                                                 |
| 567  | Недопустимая сумма                                                                                                                                           | Invalid amount                                                          |
| 568  | Транзакция отвергнута внешним хостом                                                                                                                         | External decline                                                        |
| 569  | Несогласованный запрос (данная карта не обслуживается в данном терминале)                                                                                    | No sharing                                                              |
| 571  | Необходимо обратиться к издателю                                                                                                                             | Contact card issuer                                                     |
| 572  | Авторизатор недоступен                                                                                                                                       | Destination not available                                               |
| 573  | Ошибка маршрутизации                                                                                                                                         | Routing error                                                           |
| 574  | Ошибка формата                                                                                                                                               | Format error                                                            |
| 575  | Транзакция отвергнута внешним хостом по специальному условию (владелец карты подозревается в мошенничестве)                                                  | External decline special condition                                      |
| 580  | Неверный CVV                                                                                                                                                 | Bad CVV                                                                 |
| 581  | Неверный CVV2                                                                                                                                                | Bad CVV2                                                                |
| 582  | Неверная транзакция (транзакция не разрешена с такими условиями проведения)                                                                                  | Invalid transaction                                                     |
| 583  | Лимит на число неверных вводов PIN-кода  УЖЕ достигнут  (т.е. ранее был достигнут лимит на число неверных вводов PIN-кода, после чего был введен верный PIN) | PIN tries limit was exceeded                                            |
| 584  | Неверное значение проверочного числа 3D Secure Cardholder Authentication Verification Value                                                                  | Bad CAVV                                                                |
| 585  | Неверное значение криптограммы ARQC                                                                                                                          | Bad ARQC                                                                |
| 800  | Ошибка формата                                                                                                                                               | Format error                                                            |
| 801  | Не найдена оригинальная транзакция для реверса                                                                                                               | Original transaction not found                                          |
| 809  | Неверная операция закрытия периода                                                                                                                           | Invalid close transaction                                               |
| 810  | Произошел тайм-аут                                                                                                                                           | Transaction timeout                                                     |
| 811  | Системная ошибка                                                                                                                                             | System error                                                            |
| 820  | Неправильный идентификатор терминала                                                                                                                         | Invalid terminal identifier                                             |
| 880  | Был послан последний пакет - прогрузка успешно завершена                                                                                                     | Download has been received in its entirety                              |
| 881  | Предыдущий этап прогрузки был успешно выполнен –имеются еще данные                                                                                           | Download received successfully and there is more data for this download |
| 882  | Прогрузка терминала остановлена. Необходимо позвонить в процессинговый центр                                                                                 | Download aborted (call for service)                                     |
| 897  | Получена неверная криптограмма в транзакции                                                                                                                  | Invalid cryptogram                                                      |
| 898  | Получен неверный MAC                                                                                                                                         | Invalid MAC                                                             |
| 899  | Ошибка синхронизации                                                                                                                                         | Sequence error—resync                                                   |
| 900  | Превышено число попыток ввода PIN. Требуется захват карты                                                                                                    | Pin Tries Limit Exceeded                                                |
| 901  | Карта просрочена, требуется захват карты                                                                                                                     | Expired Card                                                            |
| 909  | Требуется захват карты                                                                                                                                       | External Decline Special Condition                                      |
| 959  | Административная транзакция не поддерживается                                                                                                                | Administrative transaction not supported                                |
| 2001 | Необходима верификация 3DS                                                                                                                                   | Need 3ds verify                                                         |

## Справочник. Коды системных ошибок

| Код  | Расшифровка                               | Расшифровка (ENG)                        |
|------|-------------------------------------------|------------------------------------------|
| -1   |  Системная ошибка                         |                                          |
| -2   | Не передан параметр merchant_id           | General                                  |
| -3   | Мерчант не найден                         | Expired card                             |
| -4   | Неправильная подпись                      | Number of PIN tries exceeded             |
| -5   | Лимит на выполнение операций              | No sharing allowed                       |
| -6   | Неверный номер карты                      | Invalid transaction                      |
| -7   | Неверная валюта                           | Transaction not supported by institution |
| -8   | Неверный  order_id                        | Lost or stolen card                      |
| -9   | Операция с таким order_id  уже существует | Invalid card status                      |
| -10  | Платеж не найден                          | Restricted status                        |
| -11  | Неверный тип операции                     | Account not found                        |
| -999 | Системная ошибка                          | Wrong customer information for payment   |