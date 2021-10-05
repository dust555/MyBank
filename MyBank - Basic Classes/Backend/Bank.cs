﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using Backend.Accounts;
using Backend.Cards;
using Backend.Customers;

namespace Backend
{
    public class Bank
    {

        public List<Customer> CusomerList {get;} = new ();
        public List<SavingAccount> SavingAccountList {get;} = new ();
        public List<CurrentAccount> CurrentAccountList{get;} = new ();
        public List<CreditCard> CreditCardList{get;} = new ();


        public Bank(){
            Trace.Listeners.Add(new TextWriterTraceListener("MyBank.log", "FileListener"));
            Trace.AutoFlush = true;
            

            Trace.WriteLine("New bank created", "Info");
        }

        ///<summary>Create a customer, customer information will be asked in the console</summary>
        public Customer CreateCustomer(){
            Customer c = new Customer();
            CusomerList.Add(c);
            return c;
        }        
        
        ///<summary>Create a customer, customer information is provided as parameters</summary>
        public Customer CreateCustomer(String name, String phone, DateTime birthday){
            Customer c = new Customer(name, phone, birthday);
            CusomerList.Add(c);
            return c;
        }

        public SavingAccount CreateSavingAccount(){
            SavingAccount s = new ();
            SavingAccountList.Add(s);
            return s;
        }

        public CurrentAccount CreateCurrentAccount(){
            CurrentAccount c = new ();
            CurrentAccountList.Add(c);
            return c;
        }

        public void RemoveCurrentAccount(CurrentAccount caccount){
            if(caccount.Balance == 0){
                CurrentAccountList.Remove(caccount);
                Trace.WriteLine($"CurrentAccount removed: {caccount.ToString()}","Info");
            }
            else{
                Trace.WriteLine($"CurrentAccount cannot be removed when balance is not 0: {caccount.ToString()}","Error");
            }
        }

        public CreditCard CreateCreditCard(Customer customer){
            CreditCard c = new CreditCard(customer);
            CreditCardList.Add(c);
            return c;
        }

        public void RemoveCreditCard(CreditCard ccard){
            if(ccard.Balance == 0){
                CreditCardList.Remove(ccard);
                Trace.WriteLine($"CreditCard removed: {ccard.ToString()}","Info");
            }
            else{
                Trace.WriteLine($"CreditCard cannot be removed when balance is not 0: {ccard.ToString()}","Error");
            }
        }

        public void AddCustomerToAccount(Account account, Customer customer){
            account.AddCustomer(customer);
        }

        public BankCard AddBankCardToCurrentAccount(CurrentAccount caccount, Customer customer){
            return caccount.AddBankCard(customer);
        }

        public void RemoveBankCardFromCurrentAccount(CurrentAccount caccount, BankCard bcard){
            caccount.BankCards.Remove(bcard);
        }
    }
}
