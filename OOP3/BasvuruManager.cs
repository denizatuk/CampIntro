﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {
            //Başvuran bilgilerini değerlendirme
            //
            //IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            krediManager.Hesapla();

        }
    }
}
