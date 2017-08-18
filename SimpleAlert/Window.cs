using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Linq;
using System.Collections.Generic;

namespace SimpleAlert
{
    [TestClass]
    public class Window
    {
        [TestMethod]
        public void TestWindow1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "http://toolsqa.com/automation-practice-switch-windows/";

            //mapeia a página principal (parent window)
            String parentWindowHandle = driver.CurrentWindowHandle;
            Console.WriteLine("Parent window's handle -> " + parentWindowHandle);

            //armaneza na variavel a posição do elemento
            IWebElement clickElement = driver.FindElement(By.Id("button1"));

            //clica 3 vezes no link da página, abre 3 páginas filhas (child window of parent window)
            for (var i=0; i<3; i++)
            {
                clickElement.Click();
                Thread.Sleep(3000);
            }

            //armazena toda janela aberta em uma lista
            //imprime cada um e todos da lista
            List<string> lstWindow = driver.WindowHandles.ToList();
            foreach (var handle in lstWindow)
            {
                Console.WriteLine(handle);
            }
        }
        [TestMethod]
        public void TestWindow2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "http://toolsqa.com/automation-practice-switch-windows/";

            //mapeia a página principal (parent window)
            String parentWindowHandle = driver.CurrentWindowHandle;
            Console.WriteLine("Parent window's handle -> " + parentWindowHandle);

            IWebElement clickElement = driver.FindElement(By.Id("button1"));

            //repetição para clicar várias vezes no botão para abrir várias páginas
            for (var i=0; i<3; i++)
            {
                clickElement.Click();
                Thread.Sleep(3000);
            }

            //mapeia todas as janelas em uma lista
            List<string> lstWindow = driver.WindowHandles.ToList();

            foreach (var handle in lstWindow)
            {
                Console.WriteLine("Switing to window -> " + handle);
                Console.WriteLine("Navigation to google.com");

                //navega até onde a primeira página deseja e executa comandos usando o driver
                driver.SwitchTo().Window(handle);
                driver.Navigate().GoToUrl("http://google.com");
            }
        }
        [TestMethod]
        public void TestWindow3()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "http://toolsqa.com/automation-practice-switch-windows/";

            //mapeia a página principal (parent window)
            String parentWindowHandle = driver.CurrentWindowHandle;
            Console.WriteLine("Parent window's handle -> " + parentWindowHandle);

            IWebElement clickElement = driver.FindElement(By.Id("button1"));

            //repetição para clicar várias vezes no botão para abrir várias páginas
            for (var i = 0; i < 3; i++)
            {
                clickElement.Click();
                Thread.Sleep(3000);
            }

            /*
			* driver.WindowHandles é um ReadOnlycollection então utilizo '.ToList()' e armazeno na lista 'List<string>'
			* Novamente utilizo 'for loop' para percorrer todas as janelas que são abertas pelo loop acima
			* então eu utilizo '.SwitchTo().Window'. Basicamente utilizo para navegar até o controle da janela principal (Parent) para a janela corrente
			**/

            //mapeia todas as janelas em uma lista
            List<string> lstWindow = driver.WindowHandles.ToList();
            String lastWindowHandle = "";


            foreach (var handle in lstWindow)
            {
                Console.WriteLine("Switing to window -> " + handle);
                Console.WriteLine("Navigation to google.com");

                //navega até onde a primeira página deseja e executa comandos usando o driver
                driver.SwitchTo().Window(handle);
                driver.Navigate().GoToUrl("http://google.com");
                lastWindowHandle = handle;
            }

            //navega até a janela principal (Parent)
            driver.SwitchTo().Window(parentWindowHandle);

            //fecha a tela principal (parent) corrente
            driver.Close();

            //agora precisamos definir a página que será ser o foco após o fechamento da janela
            driver.SwitchTo().Window(lastWindowHandle);

            driver.Url = "http://toolsqa.com";

            driver.Quit();
        }

    }
}
