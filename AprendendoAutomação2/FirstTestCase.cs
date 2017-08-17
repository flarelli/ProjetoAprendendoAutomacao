using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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

            
            //imprime no console todas as opções do select 
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            driver.Url = "http://toolsqa.wpengine.com/automation-practice-form/";

            SelectElement oSelection = new SelectElement(driver.FindElement(By.Id("continents")));

            IList<IWebElement> elementCount = oSelection.Options;

            int iSize = elementCount.Count;

            for (int i = 0; i < iSize; i++)
            {
                String sValue = elementCount.ElementAt(i).Text;
                Console.WriteLine(sValue);
                //oSelection.SelectByIndex(i);

                //Thread.Sleep(2000);
            }
            
            //exercicio de seleção de combobox
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            driver.Url = "http://toolsqa.wpengine.com/automation-practice-form/";

            SelectElement oSelection = new SelectElement(driver.FindElement(By.Id("continents")));

            //seleção da opção Europa no campo Continente
            oSelection.SelectByIndex(1);

            //para esperar a seleção e fazer a mudança
            Thread.Sleep(2000);

            //seleção da opção Africa no campo Continente
            oSelection.SelectByText("Africa");

            //para esperar a seleção e fazer a mudança
            Thread.Sleep(2000);

            //exibir todas as opções do combo no console
            IList<IWebElement> opcoes = oSelection.Options;

            int totallista = opcoes.Count;

            for (int i = 0; i < totallista; i++)
            {
                //percorre a lista do combo 
                String vValue = oSelection.Options.ElementAt(i).Text;

                //exibe as opções no console
                Console.WriteLine("Valor do campo seleção é: " + vValue);

                if (vValue.Equals("Antartica"))
                {
                    oSelection.SelectByIndex(i);
                    Console.WriteLine("Valor selecionado da lista é:" + vValue);
                    break;
                }
            }
            driver.Close();
           

            //exercício de seleção de combo multiple selection
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            driver.Url = "http://toolsqa.wpengine.com/automation-practice-form/";

            SelectElement oSelection = new SelectElement(driver.FindElement(By.Name("selenium_commands")));

            //selecionar a opção "Browser Commands" no campo "Selenium Commands" por index
            oSelection.SelectByIndex(0);
            
            //espera para ver se selecionou
            Thread.Sleep(2000);

            //desmarca a seleção por index
            oSelection.DeselectByIndex(0);

            //espera para ver se desmarcou
            Thread.Sleep(2000);

            //selecionar a opção "Navigation Commands" no campo 'Selenium Commands' por texto
            oSelection.SelectByText("Navigation Commands");

            //espera para ver se marcou
            Thread.Sleep(2000);

            //desmarca a opção por texto
            oSelection.DeselectByText("Navigation Commands");

            //espera para ver se desmarcou
            Thread.Sleep(2000);

            //captar a lista do campo
            IList<IWebElement> lista = oSelection.Options;

            //armazena no inteiro o número total de itens
            int ilistSize = lista.Count;

            //condição para percorrer a lista inteira, a partir do total de itens 
            for (int i = 0; i < ilistSize; i++)
            {
                //percorre a lista recuperando o texto e armazenando na string
                String vValue = oSelection.Options.ElementAt(i).Text;

                //imprime o texto encontrado deste contador
                Console.WriteLine("Valores da lista: " + vValue);

                //selecionar todos os elementos um por um
                oSelection.SelectByIndex(i);

                Thread.Sleep(2000);
            }

            Thread.Sleep(2000);

            //desmarca todos os itens selecionados no for
            oSelection.DeselectAll();

            //fecha o browser
            driver.Quit();
            
            //trabalhando com tabelas dinâmicas
            // Abrir o browser para inicar a automação
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
           
            //abrir a página de exemplo com tabela dinâmica
            driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Programming_languages_used_in_most_popular_websites");
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(30));

            //localização da tabela na tela, armazenada em uma variável:
            var elemTable = driver.FindElement(By.XPath(".//*[@id='mw-content-text']/div/table[1]"));

            //obter todas as linhas da tabela
            List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
            String strRowData = "";

            //percorrer cada linha
            foreach (var elemTr in lstTrElem)
            {
                //percorrer as colunas de uma linha 
                List<IWebElement> lstTdElem = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));
                if (lstTdElem.Count > 0)
                {
                    //percorre cada coluna
                    foreach (var elemTd in lstTdElem)
                    {
                        //"\t\t" é utilizado para colocar um espaço entre dois textos
                        strRowData = strRowData + elemTd.Text + "\t\t";
                    }
                }
                else
                {
                    //imprime a tabela no console
                    Console.WriteLine("Esta é a tabela");
                    Console.WriteLine(lstTrElem[0].Text.Replace(" ", "\t\t"));
                }
                Console.WriteLine(strRowData);
                strRowData = String.Empty;
            }
            Console.WriteLine("");
            //driver.Quit();
            */
            }
        }
    }

