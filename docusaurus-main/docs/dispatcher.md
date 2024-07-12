---
id: dispatcher
title: Specification for the interaction of the merchant with the Dispatcher software.
---
## Payment on the payment processing page

To pay on the payment processing page, you need to redirect to the page of the processing center, with POST data.
Production url: (https://pay.concord.ua/api/)

POST parameters:

 
| Parameter    | Description                                                                                                                                                                          | Значение        |
|--------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-----------------|
| operation    | Тип операции                                                                                                                                                                      | Purchase        |
| merchant_id  | ID мерчанта, выдается поцесcингом                                                                                                                                                 |                 |
| amount       | Сумма операции. Пример 500.00                                                                                                                                                     |                 |
| signature    | В целях подтверждения валидности данных должна быть сгенерирована и передана в запросе HMAC_MD5 контрольная подпись с использованием SecretKey торговца.                          |                 |
|              | Строка, подлежащая HMAC_MD5, генерируется путем конкатенации параметров merchant_id,order_id,amount,currency_iso,description разделенных “;” (точка с запятой) в кодировке UTF-8. |                 |
|              | Порядок параметров при конкатенации важен!                                                                                                                                        |                 |
| order_id     | Уникальный номер операции на стороне торговца. Если операция дублируется - торговец получает ошибку.                                                                              |                 |
| currency_iso | Валюта платежа.                                                                                                                                                                   | UAH             |
| description  | Назначение платежа. Выводится на платежной странице, при вводе платежных реквизитов. Отображается в выписке по счету и реестрах                                                   |                 |
| add_params   | Массив с дополнительными параметрами. Дополнительные параметры потом возвращаются мерчанту в callback вызове                                                                      |                 |
| approve_url  | URL для переадресации в случае, если платеж успешен                                                                                                                               |                 |
| decline_url  | URL для переадресации в случае, если платеж не успешен                                                                                                                            |                 |
| cancel_url   | URL для переадресации в случае, если пользователь отказался совершить оплату                                                                                                      |                 |
| callback_url | URL на который прийдет информация о результате выполнения платежа                                                                                                                 |                 |
| redirect     | true/false - по умолчанию true, если параметр стоит true, тогда клиент не будет получать переадресацию, а получит url платежной страницы                                          | Не обязательный |
| auth_type    | По умолчанию 1 - покупка, 2-Предавторизация                                                                                                                                       | Не обязательный |


## Callback call to send notification of payment status


Data is sent to the URL specified in the payment parameters in the field

callback_url.


Data is sent to the merchant's server in JSON format


Parameters:


|     Parameter Name | Description                                                                                                                                                                | Значения           |
|--------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------|--------------------|
| merchantAccount    | ID мерчанта                                                                                                                                                             |                    |
| orderReference     | ID операции в системе торговца                                                                                                                                          |                    |
| amount             | Сумма операции                                                                                                                                                          |                    |
| currency           | Валюта операции                                                                                                                                                         |                    |
| phone              | Номер телефона клиента(Если включен ввод телефона на платежной странице)                                                                                                |                    |
| createdDate        | Дата платежа в формате YYYY-MM-DD HH:II:SS                                                                                                                              |                    |
|                    | Пример: 2018-12-14 12:01:26                                                                                                                                             |                    |
| cardPan            | Маскированный PAN карты.                                                                                                                                                |                    |
|                    | Пример: 535277******0298                                                                                                                                                |                    |
| cardType           | Тип карты                                                                                                                                                               | Visa               |
|                    |                                                                                                                                                                         | MasterCard         |
| fee                | Комиссия за операцию                                                                                                                                                    |                    |
| transactionId      | ID транзакции на стороне ПЦ                                                                                                                                             |                    |
| type               | Тип операции. На данный момент параметр не используется                                                                                                                 |                    |
| recToken           | Токен для рекурентного платежа                                                                                                                                          |                    |
| transactionStatus  | Статус операции                                                                                                                                                         | Approved - Успешно |
|                    |                                                                                                                                                                         | Declined - Отказ   |
| reason             | Текстовая причина отказа                                                                                                                                                |                    |
| reasonCode         | Код ошибки при отказе                                                                                                                                                   |                    |
| merchantSignature  | В целях подтверждения валидности данных должна быть сгенерирована и передана в запросе HMAC_MD5 контрольная подпись с использованием SecretKey торговца.                |                    |
|                    | Строка, подлежащая HMAC_MD5, генерируется путем конкатенации параметров merchant_id,orderReference,amount,currency разделенных “;” (точка с запятой) в кодировке UTF-8. |                    |
|                    | Порядок параметров при конкатенации важен!                                                                                                                              |                    |
## Apple Pay purchase operation


Pay button on the payment page of an online store, you must implement the ApplePaySession.canMakePaymentsWithActiveCard method, this method determines whether this device supports payment using Apple Pay.


If it supports payment, you need to draw the “Buy using Apple Pay” button.


Next, you need to create an object ** ApplePaySession **, with the purchase parameters:

  countryCode: 'UA',

  currencyCode: 'UAH',

  supportedNetworks: ['visa', 'masterCard'],

  merchantCapabilities: ['supports3DS'],

  total: { label: 'Your Merchant Name', amount: '10.00' },


 

ApplePaySession.completePayment.


 

## Validation of Apple Pay merchant (api / apple / validate).



Production url: https://pay.concord.ua/api/apple/validate



POST параметры:

 | Параметр             | Описание                                                                                                                                                                          | Значение |
 |----------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|----------|
 | operation            | Тип операции                                                                                                                                                                      | Purchase |
 | apple_validation_url | Данный параметр приходит в событии onvalidatemerchant, event.validationURL                                                                                                        |          |
 |                      | Пример:                                                                                                                                                                           |          |
 |                      | session.onvalidatemerchant = (event) => {                                                                                                                                         |          |
 |                      |         console.log(event.validationURL);                                                                                                                                         |          |
 |                      | }                                                                                                                                                                                 |          |
 | merchant_id          | ID мерчанта, выдается поцесcингом                                                                                                                                                 |          |
 | amount               | Сумма операции. Пример 500.00                                                                                                                                                     |          |
 | signature            | В целях подтверждения валидности данных должна быть сгенерирована и передана в запросе HMAC_MD5 контрольная подпись с использованием SecretKey торговца.                          |          |
 |                      | Строка, подлежащая HMAC_MD5, генерируется путем конкатенации параметров merchant_id,order_id,amount,currency_iso,description разделенных “;” (точка с запятой) в кодировке UTF-8. |          |
 |                      | Порядок параметров при конкатенации важен!                                                                                                                                        |          |
 | order_id             | Уникальный номер операции на стороне торговца. Если операция дублируется - торговец получает ошибку.                                                                              |          |
 | currency_iso         | Валюта платежа.                                                                                                                                                                   | UAH      |
 | description          | Назначение платежа. Выводится на платежной странице, при вводе платежных реквизитов. Отображается в выписке по счету и реестрах                                                   |          |
 | add_params           | Массив с дополнительными параметрами. Дополнительные параметры потом возвращаются мерчанту в callback вызове                                                                      |          |
 | callback_url         | URL на который придет информация о результате выполнения платежа                                                                                                                  |          |
 

The following parameters come in response:
 
 | Parameter            | Description                                                                       |
 |---------------------|--------------------------------------------------------------------------------|
 | apple_validate_data | Данные которые необходимо передать в метод  session.completeMerchantValidation |
 | order_key           | Идентификатор заказа в платежной системе                                       |
 | code                | Код ответа если 0 - все ок                                                     |
 | message             | Расшифровка кода ответа                                                        |