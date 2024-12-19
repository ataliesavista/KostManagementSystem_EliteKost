using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Windows.Forms;
using RoundedShape2;

namespace RoundedShapeTest
{
    [TestClass]
    public class UnitTest1
    {
        //Jenis komponen (control) yang akan diuji (Button dengan W = 100, Height = 50)
        private Button TestingButton(int width = 100, int height = 50)
        {
            return new Button
            {
                Width = width,
                Height = height
            };
        }

        //1. Memeriksa SetRounded ketika control dan radius valid.
        [TestMethod]
        public void TestSetRounded1()
        {
            var testButton = TestingButton();
            int radius = 20;
            Rounded.SetRounded(testButton, radius);

            //Assert => memastikan suatu kondisi
            //Region => mengacu pada area tampilan dari komponen.
            Assert.IsNotNull(testButton.Region, "Region adalah TIDAK NULL untuk input control dan radius yang valid.");
        }

        //2. Memeriksa SetRounded ketika radius invalid
        [TestMethod]
        public void TestSetRounded2()
        {
            var testButton = TestingButton();
            int invalidRadius = -10; //invalid radius
            Rounded.SetRounded(testButton, invalidRadius);

            Assert.IsNull(testButton.Region, "Region adalah NULL untuk input radius invalid.");
        }

        //3. Memeriksa SetRounded ketika radius adalah nol.
        [TestMethod]
        public void TestSetRounded3()
        {
            var testButton = TestingButton();
            int zeroRadius = 0;
            Rounded.SetRounded(testButton, zeroRadius);

            Assert.IsNull(testButton.Region, "Region adalah NULL untuk input radius nol.");
        }
    }
}
