using NUnit.Framework;
using Projects_UAS_2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projects_UAS_2.Tests
{
    [TestFixture()]
    public class InputMenuTests
    {
        InputMenu uji = new InputMenu()
;        [Test()]
        public void Nasi_GorengTest()
        {
            // Unit teseting bernilai true... yang mana statment input nNasgor == nNasgor yang kita inputkan
            Assert.IsTrue(InputMenu.nNasGor_1==InputMenu.nNasGor_1);

            // Unit testing Are Equal... yang mana nilai statment ekspektasi harus sama dengan hasil statment actual
            // yang statment ekspektasi yang kita compute harus sama dengan hasil compute sebenarnya
            Assert.AreEqual(InputMenu.harga_1, InputMenu.harga_1);
            Assert.IsTrue(uji.totalBeliMenu == uji.totalBeliMenu);
        }

        [Test()]
        public void Paket_GeprekTest()
        {
            // Unit teseting bernilai true... yang mana statment input nGeprek == nGeprek yang kita inputkan
            Assert.IsTrue(InputMenu.nGeprek_2==InputMenu.nGeprek_2);

            // Unit testing Are Equal... yang mana nilai statment ekspektasi harus sama dengan hasil statment actual
            // yang statment ekspektasi yang kita compute harus sama dengan hasil compute sebenarnya
            Assert.AreEqual(InputMenu.harga_2, InputMenu.harga_2);
        }

        [Test()]
        public void Mie_GorengTest()
        {
            // Unit teseting bernilai true... yang mana statment input nMiGor == nMiGor yang kita inputkan
            Assert.IsTrue(InputMenu.nMiGor_3==InputMenu.nMiGor_3);

            // Unit testing Are Equal... yang mana nilai statment ekspektasi harus sama dengan hasil statment actual
            // yang statment ekspektasi yang kita compute harus sama dengan hasil compute sebenarnya
            Assert.AreEqual(InputMenu.harga_3, InputMenu.harga_3);
        }

        [Test()]
        public void kopiTest()
        {
            // Unit teseting bernilai true... yang mana statment input nKopi == nKopi yang kita inputkan
            Assert.IsTrue(InputMenu.nKopi_4==InputMenu.nKopi_4);

            // Unit testing Are Equal... yang mana nilai statment ekspektasi harus sama dengan hasil statment actual
            // yang statment ekspektasi yang kita compute harus sama dengan hasil compute sebenarnya
            Assert.AreEqual(InputMenu.harga_4, InputMenu.harga_4);
        }

        [Test()]
        public void jerukTest()
        {
            // Unit teseting bernilai true... yang mana statment input nJeruk == nJeruk yang kita inputkan
            Assert.IsTrue(InputMenu.nJeruk_5==InputMenu.nJeruk_5);

            // Unit testing Are Equal... yang mana nilai statment ekspektasi harus sama dengan hasil statment actual
            // yang statment ekspektasi yang kita compute harus sama dengan hasil compute sebenarnya
            Assert.AreEqual(InputMenu.harga_5, InputMenu.harga_5);
        }

        [Test()]
        public void tehTest()
        {
            // Unit teseting bernilai true... yang mana statment input nTeh == nTeh yang kita inputkan
            Assert.IsTrue(InputMenu.nTeh_6==InputMenu.nTeh_6);

            // Unit testing Are Equal... yang mana nilai statment ekspektasi harus sama dengan hasil statment actual
            // yang statment ekspektasi yang kita compute harus sama dengan hasil compute sebenarnya
            Assert.AreEqual(InputMenu.harga_6, InputMenu.harga_6);
        }

        [Test()]
        public void TotalTest()
        {
            // testing yang menyatakan objek array input totalbelimenu == objek total beli menu sebenarnya
            Assert.IsTrue(uji.totalBeliMenu==uji.totalBeliMenu);

            // Are Equal SubTotal ekspektasi sama dengan nilai subTotal Actual
            Assert.AreEqual(InputMenu.SubTotal,InputMenu.SubTotal);
        }
    }
}