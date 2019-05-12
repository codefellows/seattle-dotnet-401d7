using AuthorizeNet.Api.Contracts.V1;
using AuthorizeNet.Api.Controllers;
using AuthorizeNet.Api.Controllers.Bases;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace CMSBlogPost.Models
{
    public class Payment
    {
        public IConfiguration Configuration { get; }

        public Payment(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public string Run()
        {
            ApiOperationBase<ANetApiRequest, ANetApiResponse>.RunEnvironment = AuthorizeNet.Environment.SANDBOX;

            // define our merchant information
            ApiOperationBase<ANetApiRequest, ANetApiResponse>.MerchantAuthentication = new merchantAuthenticationType()
            {
                name = Configuration["AuthorizeNetName"],
                ItemElementName = ItemChoiceType.transactionKey,
                Item = Configuration["AuthorizeNetTransKey"]
            };

            creditCardType creditCard = new creditCardType
            {
                cardNumber = Configuration["CreditCardNumber"],
                expirationDate = Configuration["ExpirationDate"]
            };

            customerAddressType billingAddress = GetAddress();

            paymentType paymentType = new paymentType { Item = creditCard };

            transactionRequestType transReqType = new transactionRequestType
            {
                transactionType = transactionTypeEnum.authCaptureTransaction.ToString(),
                amount = 123.45m,
                payment = paymentType,
                billTo = billingAddress
            };


            createTransactionRequest request = new createTransactionRequest
            {
                transactionRequest = transReqType
            };

            var controller = new createTransactionController(request);
            controller.Execute();

            var response = controller.GetApiResponse();

            if (response != null)
            {
                if(response.messages.resultCode == messageTypeEnum.Ok)
                {
                    // out transaction was successful. 
                    return "OK";
                }
                else
                {
                    // it was not successful
                }
            }

            return "NOT OK";
        }

        customerAddressType GetAddress()
        {
            customerAddressType address = new customerAddressType()
            {
                firstName = "Josie",
                lastName = "Cat",
                address = "123 CatNip Lane",
                city = "Cat Mountain",
                zip = "98119"
            };

            return address;
        }

        // bring in a List<Products>
        private lineItemType[] GetLineItems(List<Post> posts)
        {
            lineItemType[] items = new lineItemType[posts.Count];

            int count = 0;
            foreach (var item in posts)
            {
                items[count] = new lineItemType
                {
                    itemId = "1",
                    name = "This is my post's name except probably a product",
                    quantity = 5,
                    unitPrice = 5.00m
                };
            }

            return items;
        }
    }
}
