using LinqUI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqUI
{
    public class SampleData
    {
        public static List<ContactModel> GetContactData() 
        {
            List<ContactModel> output = new List<ContactModel> 
            {
                new ContactModel{Id=1,FirstName="Darshit",LastName="Shah",Addresses = new List<int> {1,2,3,}},
                new ContactModel{Id=1,FirstName="Bilbo",LastName="Beggins",Addresses = new List<int> {1}},
                new ContactModel{Id=1,FirstName="Will",LastName="Biers",Addresses = new List<int> {2}},
                new ContactModel{Id=1,FirstName="Nick",LastName="Fury",Addresses = new List<int> {3}},
                new ContactModel{Id=1,FirstName="John",LastName="Cena",Addresses = new List<int> {2,3,}}
            };
            return output;
        }
        public static List<AddressModel> GetAddressData() 
        {
            List<AddressModel> output = new List<AddressModel> {
                new AddressModel { Id=1,ContactId = 1,City="Rajkot",State="Gujrat"},
                new AddressModel { Id=2,ContactId = 1,City="Hawkins",State="US"},
                new AddressModel { Id=3,ContactId = 2,City="America",State="USA"},
                new AddressModel { Id=4,ContactId = 5,City="Kingship",State="US"},
                new AddressModel { Id=5,ContactId = 5,City="Chestermill",State="USA"},
                new AddressModel { Id=6,ContactId = 4,City="Canada",State="US"},
                new AddressModel { Id=7,ContactId = 3,City="Peris",State="USA"},
            };
            return output;  
        }
    }
}
