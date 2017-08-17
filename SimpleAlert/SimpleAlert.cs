using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SimpleAlert
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://toolsqa.wpengine.com/handling-alerts-using-selenium-webdriver/";
            driver.Manage().Window.Maximize();


            //abre o alert simples na tela do browser
            driver.FindElement(By.XPath(".//*[@id='content']/p[4]/button")).Click();

            //altera o controle do driver para o Alerta 
            IAlert simpleAlert = driver.SwitchTo().Alert();

            //recuperar o texto exibido no alerta
            String alertText = simpleAlert.Text;
            Console.WriteLine("Alert text is: " + alertText);

            //.Accept() é utilizado para clicar no OK do Alerta
            simpleAlert.Accept();
        }
        [TestMethod]
        public void TestMethod2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://toolsqa.wpengine.com/handling-alerts-using-selenium-webdriver/";
            driver.Manage().Window.Maximize();


            //localiza e armazena o botão que abre o alerta
            IWebElement element = driver.FindElement(By.XPath(".//*[@id='content']/p[8]/button"));

            //'IJavaScriptExecutor' é uma interface utilizada para rodar 'código Javascript' dentro do webdriver (Browser)
            //para selecionar o botão para abrir o alerta de confirmação
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", element);

            //altera o driver da página para a tela do Alerta exibido
            IAlert confirmationAlert = driver.SwitchTo().Alert();

            //pega o texto do alerta
            String alertText = confirmationAlert.Text;

            Console.WriteLine("Texto do Alerta é: " + alertText);

            //'.Dismiss()' é utilizado para cancelar o alerta exibido, clica no NÃO
            confirmationAlert.Dismiss();
        }
        [TestMethod]
        public void TestMethod3()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://toolsqa.wpengine.com/handling-alerts-using-selenium-webdriver/";
            driver.Manage().Window.Maximize();

            //localiza o botão que abre o alerta
            IWebElement element = driver.FindElement(By.XPath(".//*[@id='content']/p[11]/button"));

            //'IJavaScriptExecutor' é uma interface utilizada para rodar 'código Javascript' dentro do webdriver (Browser)
            //para selecionar o botão para abrir o alerta de confirmação
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", element);

            //altera o driver da página para a tela do Alerta exibido
            IAlert confirmationAlert = driver.SwitchTo().Alert();

            //pega o texto do alerta
            String alertText = confirmationAlert.Text;
            Console.WriteLine("Texto do Alerta é " + alertText);

            //'.SendKeys()' envia um texto
        }
    }
}
