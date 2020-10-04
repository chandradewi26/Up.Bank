using System;

namespace Up.Bank.BusinessLogic.DomainModel
{
    public class Transaction
    {

        public Transaction()
        {
            ID = " There's no transaction ID, no transcation stored. ";
            Type = "transactions";
            Value = 0;
            Description = "Transfer from Saving to Spending.";
            Message = "Spending for what?";
            SettledAt = DateTime.Now;
        }
        //public DateTime (int year, int month, int day, int hour, int minute, int second);
        public Transaction(String id, String type, decimal value, String description, String message, DateTime settledAt)
        {
            if (value < 0)
                throw new Exception("Transaction cant be less than 0");
            ID = id;
            Type = type;
            Value = value;
            Description = description;
            Message = message;
            SettledAt = settledAt;
        }

        public String ID { get; set; }
        public string Type { get; set; }
        public decimal Value { get; set; }
        public string Description { get; set; }
        public String Message { get; set; }
        public DateTime SettledAt { get; set; }

    }
}





/*
        {
            "type": "transactions",
            "id": "13fc7191-d6b1-48ca-8b1a-d03cfebf3865",
            "attributes": {
                "status": "SETTLED",
                "rawText": null,
                "description": "Interest",
                "message": null,
                "holdInfo": null,
                "roundUp": null,
                "cashback": null,
                "amount": {
                    "currencyCode": "AUD",
                    "value": "0.64",
                    "valueInBaseUnits": 64
                },
                "foreignAmount": null,
                "settledAt": "2020-10-01T04:24:51+10:00",
                "createdAt": "2020-10-01T04:24:51+10:00"
            },
            "relationships": {
                "account": {
                    "data": {
                        "type": "accounts",
                        "id": "73575f94-61bb-4863-aace-65f0d964c99c"
                    },
                    "links": {
                        "related": "https://api.up.com.au/api/v1/accounts/73575f94-61bb-4863-aace-65f0d964c99c"
                    }
                },
                "category": {
                    "data": null
                },
                "parentCategory": {
                    "data": null
                },
                "tags": {
                    "data": [],
                    "links": {
                        "self": "https://api.up.com.au/api/v1/transactions/13fc7191-d6b1-48ca-8b1a-d03cfebf3865/relationships/tags"
                    }
                }
            },
            "links": {
                "self": "https://api.up.com.au/api/v1/transactions/13fc7191-d6b1-48ca-8b1a-d03cfebf3865"
            }
        },
        */