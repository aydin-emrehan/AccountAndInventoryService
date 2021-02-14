﻿using ShopInGame.Abstract;
using ShopInGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopInGame.Concreate
{
    public class AccountManager : IAccountManager
    {
        public void Delete(Account account)
        {
            Console.WriteLine(account.Name + " Kullanıcısının Hesabı Silindi");
        }
        public void Update(Account account)
        {
            Console.WriteLine(account.Name + " Kullanıcısının bilgileri Güncellendi");
        }
    }
}
