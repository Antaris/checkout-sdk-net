﻿using System.Runtime.Serialization;

namespace Checkout.Common
{
    public enum PaymentSourceType
    {
        [EnumMember(Value = "card")] Card,
        [EnumMember(Value = "id")] Id,
        [EnumMember(Value = "network_token")] NetworkToken,
        [EnumMember(Value = "token")] Token,
        [EnumMember(Value = "customer")] Customer,
        [EnumMember(Value = "provider_token")] ProviderToken,
        [EnumMember(Value = "dLocal")] DLocal,

        [EnumMember(Value = "currency_account")]
        CurrencyAccount,
        [EnumMember(Value = "boleto")] Boleto,
        [EnumMember(Value = "fawry")] Fawry,
        [EnumMember(Value = "giropay")] Giropay,
        [EnumMember(Value = "ideal")] Ideal,
        [EnumMember(Value = "oxxo")] Oxxo,
        [EnumMember(Value = "pagofacil")] PagoFacil,
        [EnumMember(Value = "rapipago")] RapiPago,
        [EnumMember(Value = "klarna")] Klarna,
        [EnumMember(Value = "sofort")] Sofort,
        [EnumMember(Value = "knet")] KNet,
        [EnumMember(Value = "qpay")] QPay,
        [EnumMember(Value = "alipay")] Alipay,
        [EnumMember(Value = "paypal")] PayPal,
        [EnumMember(Value = "multibanco")] Multibanco,
        [EnumMember(Value = "eps")] EPS,
        [EnumMember(Value = "poli")] Poli,
        [EnumMember(Value = "p24")] Przelewy24,
        [EnumMember(Value = "benefitpay")] BenefitPay,
        [EnumMember(Value = "bancontact")] Bancontact,
        [EnumMember(Value = "tamara")] Tamara,
        [EnumMember(Value = "bank_account")] BankAccount,
        [EnumMember(Value = "alipay_hk")] AlipayHk,
        [EnumMember(Value = "alipay_cn")] AlipayCn,
        [EnumMember(Value = "alipay_plus")] AlipayPlus,
        [EnumMember(Value = "gcash")] Gcash,
        [EnumMember(Value = "wechatpay")] Wechatpay,
        [EnumMember(Value = "dana")] Dana,
        [EnumMember(Value = "kakaopay")] Kakaopay,
        [EnumMember(Value = "truemoney")] Truemoney,
        [EnumMember(Value = "tng")] Tng,
        [EnumMember(Value = "afterpay")] Afterpay,
        [EnumMember(Value = "benefit")] Benefit,
        [EnumMember(Value = "mbway")] Mbway,
        [EnumMember(Value = "postfinance")] Postfinance,
        [EnumMember(Value = "stcpay")] Stcpay,
        [EnumMember(Value = "alma")] Alma
    }
}