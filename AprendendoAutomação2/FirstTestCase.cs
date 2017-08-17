using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace AprendendoAutomaçãoSelenium
{
    public class FirstTestCase
    {
        static void Main(string[] args)
        {
            /*
            //exercício 1
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://toolsqa.wpengine.com/automation-practice-form/";

            driver.FindElement(By.Name("firstname")).SendKeys("Lankshay");

            driver.FindElement(By.Name("lastname")).SendKeys("Sharma");

            driver.FindElement(By.Id("submit")).Click();
            
            //exercício 2

            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://toolsqa.wpengine.com/automation-practice-form/";

            driver.FindElement(By.PartialLinkText("Partial")).Click();
            Console.WriteLine("Partial Link Test Pass");

            String sClass = driver.FindElement(By.TagName("button")).ToString();
            Console.WriteLine(sClass);

            driver.FindElement(By.LinkText("Link Test")).Click();
            Console.WriteLine("Link Test Pass");

            

            //exemplo with selected radiobutton/checkbutton

            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://toolsqa.wpengine.com/automation-practice-form/";

            // Store all the elements of same category in the list of WebLements	
            IList<IWebElement> oRadioButton = driver.FindElements(By.Name("sex"));
            
            // Create a boolean variable which will hold the value (True/False)
            bool bValue = false;

            // This statement will return True, in case of first Radio button is selected
            bValue = oRadioButton.ElementAt(0).Selected;

            // This will check that if the bValue is True means if the first radio button is selected
            if (bValue == true)
            {
                // This will select Second radio button, if the first radio button is selected by default
                oRadioButton.ElementAt(1).Click();
            }
            else
            {
                // If the first radio button is not selected by default, the first will be selected
                oRadioButton.ElementAt(0).Click();
            }
            
            //como marcar o checkbox de acordo com o seu valor
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://toolsqa.wpengine.com/automation-practice-form/";

            // Find the checkbox or radio button element by Name
            IList<IWebElement> oCheckBox = driver.FindElements(By.Name("exp"));

            // This will tell you the number of checkboxes are present
            int Size = oCheckBox.Count;

            // Start the loop from first checkbox to last checkboxe
            for (int i = 0; i < Size; i++)
            {
                // Store the checkbox name to the string variable, using 'Value' attribute
                String Value = oCheckBox.ElementAt(i).GetAttribute("value");

                // Select the checkbox it the value of the checkbox is same what you are looking for
                if (Value.Equals("3"))
                {
                    oCheckBox.ElementAt(i).Click();
                    // This will take the execution out of for loop
                    break;
                }
            }

            
            //CssSelector como utilizar para marcar radiobutton/checkbox
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://toolsqa.wpengine.com/automation-practice-form/";

            IWebElement oCheckBox = driver.FindElement(By.CssSelector("input[value='Selenium IDE']"));

            oCheckBox.Click();
           

            //exercicio
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            driver.Url = "http://toolsqa.wpengine.com/automation-practice-form/";

            //selecionando um item do checkbox que esta desmarcado(pega o primeiro item)
            IList<IWebElement> rdBtn_Sex = driver.FindElements(By.Name("sex"));

            Boolean bValue = false;

            bValue = rdBtn_Sex.ElementAt(0).Selected;

            if (bValue == true)
            {
                rdBtn_Sex.ElementAt(1).Click();
            }
            else
            {
                rdBtn_Sex.ElementAt(0).Click();
            }

            //selecionando um item no checkbox pelo id
            IWebElement radioBtn = driver.FindElement(By.Id("exp-2"));

            radioBtn.Click();

            //varrendo o checkbox e selecionando o do valor igual a Automation Tester
            IList<IWebElement> btnCheckBox = driver.FindElements(By.Name("profession"));

            int Size = btnCheckBox.Count();

            for (int i=0; i< Size; i++)
            {
                String Value = btnCheckBox.ElementAt(i).GetAttribute("value");

                if (Value.Equals("Automation Tester"))
                {
                    btnCheckBox.ElementAt(i).Click();
                    break;
                }
            }

            //selecionando um elemento pelo CSS dele
            driver.FindElement(By.CssSelector("input[value='Selenium IDE']")).Click();

           

            //seleção de DropDown e MultipleSelections
            //retorna a quantidade de opções dentro de um select
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            driver.Url = "http://toolsqa.wpengine.com/automation-practice-form/";

            SelectElement oSelect = new SelectElement(driver.FindElement(By.Id("continents")));
            IList<IWebElement> elementCount = oSelect.Options;
            Console.WriteLine("Quantidade de opções do select:  " + elementCount.Count);

            */
            //exibe as opções do select 
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            driver.Url = "http://toolsqa.wpengine.com/automation-practice-form/";

            SelectElement oSelect = new SelectElement(driver.FindElement(By.Id("continents")));

            IList<IWebElement> elementCount = oSelect.Options;

            int iSize = elementCount.Count;

            for (int i = 0; i > iSize; i++)
            {
                string sValue = elementCount.ElementAt(i).Text;
                Console.WriteLine(sValue);



            }

        }
    }
}
