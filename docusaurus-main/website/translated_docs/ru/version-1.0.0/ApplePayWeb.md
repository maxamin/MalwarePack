---
id: version-1.0.0-ApplePayWeb
title: ApplePayWeb
original_id: ApplePayWeb
---
## Операция покупки через Apple Pay

Для  интеграции кнопки  Apple Pay  на платежную страницу интернет магазина необходимо реализовать метод ApplePaySession.canMakePaymentsWithActiveCard, этот метод определяет поддерживает ли данное устройство оплату с помощью Apple Pay.


Если поддерживает оплата - необходимо отрисовать кнопку “Купить с помощью Apple Pay”.


Далее необходимо создать объект **ApplePaySession** , с параметрами покупки:
``` js
  countryCode: 'UA',
  currencyCode: 'UAH',
  supportedNetworks: ['visa', 'masterCard'],
  merchantCapabilities: ['supports3DS'],
  total: { label: 'Your Merchant Name', amount: '10.00' },

```
Описание полей можно посмотреть в документации Apple Pay on Web.


На событие **onvalidatemerchant** необходимо повесить обработчик, в котором будет вызываться API “api/apple/validate” . Описание метода будет ниже.

На событие **onpaymentauthorized** необходимо повесить обработчик, который будет вызывать API “api/apple/payment”.


После подтверждения платежа в **onpaymentauthorized** необходимо вызвать метод

**ApplePaySession.completePayment**.


Документацию по ApplePaySession можно найти на оф сайте Apple (https://developer.apple.com/documentation/apple_pay_on_the_web/apple_pay_js_api).


## Валидация мерчанта Apple Pay (api/apple/validate). 
 
 **Production url:** https://pay.concord.ua/api/apple/validate
 
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
 
 
В ответ приходят следующие параметры:

| Параметр            | Описание                                                                       |
|---------------------|--------------------------------------------------------------------------------|
| apple_validate_data | Данные которые необходимо передать в метод  session.completeMerchantValidation |
| order_key           | Идентификатор заказа в платежной системе                                       |
| code                | Код ответа если 0 - все ок                                                     |
| message             | Расшифровка кода ответа                                                        |


## Подтверждение платежа Apple Pay (api/apple/payment)

**Production url:**   https://pay.concord.ua/api/apple/payment

POST параметры:

| Название               | Описание                                                                                                |
|------------------------|---------------------------------------------------------------------------------------------------------|
| order_key              | Идентификатор заказа в платежной системе                                                                |
| apple_pay_payment_data | Данные закодированные в base64, полученные в newсобытии onpaymentauthorized в параметре  event.payment. |
|                        | Пример:                                                                                                 |
|                        | session.onpaymentauthorized = (event) => {                                                              |
|                        |         console.log(event.payment);                                                                     |
|                        | }                                                                                                       |
|                        |                                                                                                         |

В ответ приходит:
| transactionStatus | Статус операции          | Approved - Успешно / Declined - Отказ  |
|-------------------|--------------------------|--------------------|
| reason            | Текстовая причина отказа |                    |
| reasonCode        | Код ошибки при отказе    |                    |

После вызова этого метода приходит callback в backend торговца.