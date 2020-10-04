using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Up.Bank.BusinessLogic.DomainModel
{
    public class Account
    {

        public Account()
        {
            DisplayName = "No Account were stored yet"; // Account Name - Savings, Tuition Fee, etc.
            Value = 0;
            AccountType = "Saver / Transactional";
        }

        public Account(decimal value, string name, string type)
        {
            if (value < 0)
                throw new Exception("Value invalid, value cant be lower than 0");

            DisplayName = name;
            Value = value;
            AccountType = type;
        }
        public string DisplayName { get; set; }
        public string AccountType { get; set; }
        public decimal Value { get; set; }
    }
}




/*
 * 
    "data": [
        {
            "type": "accounts",
            "id": "4e7f1557-92ca-458f-8682-f7902ec1bb91",
            "attributes": {
                "displayName": "Up Account",
                "accountType": "TRANSACTIONAL",
                "balance": {
                    "currencyCode": "AUD",
                    "value": "90.46",
                    "valueInBaseUnits": 9046
                },
                "createdAt": "2020-02-17T13:44:51+11:00"
            },
            "relationships": {
                "transactions": {
                    "links": {
                        "related": "https://api.up.com.au/api/v1/accounts/4e7f1557-92ca-458f-8682-f7902ec1bb91/transactions"
                    }
                }
            },
            "links": {
                "self": "https://api.up.com.au/api/v1/accounts/4e7f1557-92ca-458f-8682-f7902ec1bb91"
            }
        },
        {
            "type": "accounts",
            "id": "7131df79-a395-4eaf-b954-8d026086915a",
            "attributes": {
                "displayName": "Savings",
                "accountType": "SAVER",
                "balance": {
                    "currencyCode": "AUD",
                    "value": "3705.40",
                    "valueInBaseUnits": 370540
                },
                "createdAt": "2020-02-17T23:59:47+11:00"
            },
            "relationships": {
                "transactions": {
                    "links": {
                        "related": "https://api.up.com.au/api/v1/accounts/7131df79-a395-4eaf-b954-8d026086915a/transactions"
                    }
                }
            },
            "links": {
                "self": "https://api.up.com.au/api/v1/accounts/7131df79-a395-4eaf-b954-8d026086915a"
            }
        },
        {
            "type": "accounts",
            "id": "9b3bce6b-e123-4849-b907-9387caebdf9c",
            "attributes": {
                "displayName": "🏫 Tuition Fee",
                "accountType": "SAVER",
                "balance": {
                    "currencyCode": "AUD",
                    "value": "36486.08",
                    "valueInBaseUnits": 3648608
                },
                "createdAt": "2020-02-18T00:00:21+11:00"
            },
            "relationships": {
                "transactions": {
                    "links": {
                        "related": "https://api.up.com.au/api/v1/accounts/9b3bce6b-e123-4849-b907-9387caebdf9c/transactions"
                    }
                }
            },
            "links": {
                "self": "https://api.up.com.au/api/v1/accounts/9b3bce6b-e123-4849-b907-9387caebdf9c"
            }
        },
        {
            "type": "accounts",
            "id": "98964e4b-f61c-45e7-9d6c-7a0c04252907",
            "attributes": {
                "displayName": "🏠 Rent",
                "accountType": "SAVER",
                "balance": {
                    "currencyCode": "AUD",
                    "value": "200.00",
                    "valueInBaseUnits": 20000
                },
                "createdAt": "2020-02-24T14:50:08+11:00"
            },
            "relationships": {
                "transactions": {
                    "links": {
                        "related": "https://api.up.com.au/api/v1/accounts/98964e4b-f61c-45e7-9d6c-7a0c04252907/transactions"
                    }
                }
            },
            "links": {
                "self": "https://api.up.com.au/api/v1/accounts/98964e4b-f61c-45e7-9d6c-7a0c04252907"
            }
        },
*/