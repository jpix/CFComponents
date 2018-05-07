using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFComponentN18
{
    public class CCodiceFiscale: ICodiceFiscale 
    {

       
        
        
        public string GetCodiceFiscale => CalcCF(CFMembers);

               

        
        // default ctor
        public CCodiceFiscale()
        {

            CFMembers = new CFDataMembers();

            
        }




        
        
       public CFDataMembers CFMembers;



       

        

        private  char[] cognome;
        private  char[] nome;

        private Dictionary<string, string> EvenTable = null;
        private Dictionary<string, string> OddTable = null;
        private Dictionary<string, string> RestsTable = null;






       private void InitializeTables()
        {


            //EvenTable
            EvenTable.Add("A", "0");
            EvenTable.Add("B", "1");
            EvenTable.Add("C", "2");
            EvenTable.Add("D", "3");
            EvenTable.Add("E", "4");
            EvenTable.Add("F", "5");

            EvenTable.Add("G", "6");
            EvenTable.Add("H", "7");
            EvenTable.Add("I", "8");
            EvenTable.Add("J", "9");
            EvenTable.Add("K", "10");

            EvenTable.Add("L", "11");
            EvenTable.Add("M", "12");
            EvenTable.Add("N", "13");
            EvenTable.Add("O", "14");
            EvenTable.Add("P", "15");

            EvenTable.Add("Q", "16");
            EvenTable.Add("R", "17");
            EvenTable.Add("S", "18");
            EvenTable.Add("T", "19");
            EvenTable.Add("U", "20");

            EvenTable.Add("V", "21");
            EvenTable.Add("W", "22");
            EvenTable.Add("X", "23");
            EvenTable.Add("Y", "24");
            EvenTable.Add("Z", "25");

            EvenTable.Add("0", "0");
            EvenTable.Add("1", "1");
            EvenTable.Add("2", "2");
            EvenTable.Add("3", "3");
            EvenTable.Add("4", "4");

            EvenTable.Add("5", "5");
            EvenTable.Add("6", "6");
            EvenTable.Add("7", "7");
            EvenTable.Add("8", "8");
            EvenTable.Add("9", "9");


            //=============================================================


            //OddTable
            OddTable.Add("A", "1");
            OddTable.Add("B", "0");
            OddTable.Add("C", "5");
            OddTable.Add("D", "7");
            OddTable.Add("E", "9");
            OddTable.Add("F", "13");

            OddTable.Add("G", "15");
            OddTable.Add("H", "17");
            OddTable.Add("I", "19");
            OddTable.Add("J", "21");
            OddTable.Add("K", "2");

            OddTable.Add("L", "4");
            OddTable.Add("M", "18");
            OddTable.Add("N", "20");
            OddTable.Add("O", "11");
            OddTable.Add("P", "3");

            OddTable.Add("Q", "6");
            OddTable.Add("R", "8");
            OddTable.Add("S", "12");
            OddTable.Add("T", "14");
            OddTable.Add("U", "16");

            OddTable.Add("V", "10");
            OddTable.Add("W", "22");
            OddTable.Add("X", "25");
            OddTable.Add("Y", "24");
            OddTable.Add("Z", "23");

            OddTable.Add("0", "1");
            OddTable.Add("1", "0");
            OddTable.Add("2", "5");
            OddTable.Add("3", "7");
            OddTable.Add("4", "9");

            OddTable.Add("5", "13");
            OddTable.Add("6", "15");
            OddTable.Add("7", "17");
            OddTable.Add("8", "19");
            OddTable.Add("9", "21");



            //=============================================================


            //RestsTable
            RestsTable.Add("0", "A");
            RestsTable.Add("1", "B");
            RestsTable.Add("2", "C");
            RestsTable.Add("3", "D");
            RestsTable.Add("4", "E");
            RestsTable.Add("5", "F");

            RestsTable.Add("6", "G");
            RestsTable.Add("7", "H");
            RestsTable.Add("8", "I");
            RestsTable.Add("9", "J");
            RestsTable.Add("10", "K");
            RestsTable.Add("11", "L");

            RestsTable.Add("12", "M");
            RestsTable.Add("13", "N");
            RestsTable.Add("14", "O");
            RestsTable.Add("15", "P");
            RestsTable.Add("16", "Q");
            RestsTable.Add("17", "R");

            RestsTable.Add("18", "S");
            RestsTable.Add("19", "T");
            RestsTable.Add("20", "U");
            RestsTable.Add("21", "V");
            RestsTable.Add("22", "W");
            RestsTable.Add("23", "X");

            RestsTable.Add("24", "Y");
            RestsTable.Add("25", "Z");




        }

        //====================================================================================
        // COGNOME
        //====================================================================================
        string SetCognome(char[] cognome)
        {

            //Ricava le consonanti e le vocali 
            string tmpCognomeConsonant = "";
            string tmpCognomeVowels = "";

            string retStr = "";

            int index = -1;

            while (index < cognome.Length - 1)
            {
                index += 1;

                if (!isVowel(cognome[index]) && cognome[index] != 32)
                {
                    tmpCognomeConsonant += cognome[index];
                }

                else
                    if (isVowel(cognome[index]) && cognome[index] != 32)
                {
                    tmpCognomeVowels += cognome[index];
                }


            }


            //Se le consonanti sono 3 o più
            if (tmpCognomeConsonant.Length >= 3)
            {

                retStr = tmpCognomeConsonant.Substring(0, 3);
            }

            else

            //Se le consonanti sono 2
            if (tmpCognomeConsonant.Length == 2)
            {

                retStr = tmpCognomeConsonant.Substring(0, 2);
                retStr = retStr + tmpCognomeVowels.Substring(0, 1);
            }

            else
            
            //Se la consonante è 1 e ci sono 2 vocali
            if (tmpCognomeConsonant.Length == 1 && tmpCognomeVowels.Length >= 2)
            {

                retStr = tmpCognomeConsonant.Substring(0, 1);
                retStr = retStr + tmpCognomeVowels.Substring(0, 2);
            }

            else

            //Se il cognome contiene 1 consonante e 1 vocale
            if (tmpCognomeConsonant.Length == 1 && tmpCognomeVowels.Length == 1)
            {

                retStr = tmpCognomeConsonant.Substring(0, 1);
                retStr = retStr + tmpCognomeVowels.Substring(0, 1);
                retStr = retStr + "X";
            }

            else
            
            //Ci sono solo 2 vocali
            if (tmpCognomeConsonant.Length == 0 && tmpCognomeVowels.Length == 2)
            {

                retStr = tmpCognomeVowels.Substring(0, 2);
                retStr = retStr + "X";
            }
            else
            
            //Ultimo caso nn ci sono consonanti e più di 2 vocali
            if (tmpCognomeConsonant.Length == 0 && tmpCognomeVowels.Length > 2)
            {

                retStr = tmpCognomeVowels.Substring(0, 3);

            }






            return retStr;
        }


        //====================================================================================
        // NOME
        //====================================================================================
        string SetNome(char[] nome)
        {

            //Ricava le consonanti e le vocali 
            string tmpNomeConsonant = "";
            string tmpNomeVowels = "";

            string retStr = "";

            int index = -1;

            while (index < nome.Length - 1)
            {
                index += 1;

                if (!isVowel(nome[index]) && nome[index] != 32)
                {
                    tmpNomeConsonant += nome[index];
                }

                else
                    if (isVowel(nome[index]) && nome[index] != 32)
                {
                    tmpNomeVowels += nome[index];
                }


            }



            //Se il nome ha 4 o più consonanti
            if (tmpNomeConsonant.Length >= 4)
            {
                retStr = tmpNomeConsonant[0].ToString() + tmpNomeConsonant[2].ToString() + tmpNomeConsonant[3].ToString();
            }
            else
            
            //Se il nome ha 3 consonanti
            if (tmpNomeConsonant.Length == 3)
            {
                retStr = tmpNomeConsonant[0].ToString() + tmpNomeConsonant[1].ToString() + tmpNomeConsonant[2].ToString();
            }
            else
            
            //Se il nome ha 2 consonanti
            if (tmpNomeConsonant.Length == 2)
            {
                retStr = tmpNomeConsonant[0].ToString() + tmpNomeConsonant[1].ToString() + tmpNomeVowels[0].ToString();
            }
            else

            //Se il nome ha 1 consonante e 2 vocali
            if (tmpNomeConsonant.Length == 1 && tmpNomeVowels.Length == 2)
            {

                retStr = tmpNomeConsonant[0].ToString() + tmpNomeVowels[0].ToString() + tmpNomeVowels[1].ToString();
            }
            else
            
            //Se il nome ha 1 consonante e 1 vocale
            if (tmpNomeConsonant.Length == 1 && tmpNomeVowels.Length == 1)
            {

                retStr = tmpNomeConsonant[0].ToString() + tmpNomeVowels[0].ToString() + "X";
            }
            else
            
            //Se il nome nn ha consonanti e solo 2 vocali
            if (tmpNomeConsonant.Length == 0 && tmpNomeVowels.Length == 2)
            {

                retStr = tmpNomeVowels[0].ToString() + tmpNomeVowels[1].ToString() + "X";
            }
            else
            
            //Ultimo caso nn ci sono consonanti e più di 2 vocali
            if (tmpNomeConsonant.Length == 0 && tmpNomeVowels.Length > 2)
            {

                retStr = tmpNomeVowels[0].ToString() + tmpNomeVowels[1].ToString() + tmpNomeVowels[2].ToString();
            }


            return retStr;

        }

        //====================================================================================
        // isVowel ?
        //====================================================================================
        bool isVowel(char c)
        {

            bool isVowel = "aeiouAEIOU".IndexOf(c) >= 0;

            return isVowel;

        }


        //====================================================================================
        // MONTHS MAP
        //====================================================================================
        string GetMonthCode(string month)
        {
            string p_Month = "";
            month = month.ToLower();

            Dictionary<string, string> monthsMap = new Dictionary<string, string>();

           
            monthsMap.Add("1", "A");
            monthsMap.Add("2", "B");
            monthsMap.Add("3", "C");
            monthsMap.Add("4", "D");
            monthsMap.Add("5", "E");
            monthsMap.Add("6", "H");

            monthsMap.Add("7", "L");
            monthsMap.Add("8", "M");
            monthsMap.Add("9", "P");
            monthsMap.Add("10", "R");
            monthsMap.Add("11", "S");
            monthsMap.Add("12", "T");

            bool getCode = monthsMap.TryGetValue(month, out p_Month);

            if (!getCode)
                p_Month = "ERROR";

            return p_Month;
        }

        //====================================================================================
        // COMPUTE CONTROL CODE
        //====================================================================================
        string ControlCode(string partialCode)
        {

            string testVal = partialCode;


            int valEven = 0;
            int valOddd = 0;


            int counterVal = 1;

            foreach (char c in testVal)
            {

                switch (counterVal)
                {
                    case 1: valOddd += Convert.ToInt32(OddTable[c.ToString()]);   break;

                    case 2: valEven += Convert.ToInt32(EvenTable[c.ToString()]);  break;

                    case 3: valOddd += Convert.ToInt32(OddTable[c.ToString()]);   break;

                    case 4: valEven += Convert.ToInt32(EvenTable[c.ToString()]);  break;

                    case 5: valOddd += Convert.ToInt32(OddTable[c.ToString()]);   break;

                    case 6: valEven += Convert.ToInt32(EvenTable[c.ToString()]);  break;

                    case 7: valOddd += Convert.ToInt32(OddTable[c.ToString()]);   break;
                        
                    case 8: valEven += Convert.ToInt32(EvenTable[c.ToString()]);  break;

                    case 9: valOddd += Convert.ToInt32(OddTable[c.ToString()]);   break;

                    case 10: valEven += Convert.ToInt32(EvenTable[c.ToString()]); break;

                    case 11: valOddd += Convert.ToInt32(OddTable[c.ToString()]);  break;

                    case 12: valEven += Convert.ToInt32(EvenTable[c.ToString()]); break;

                    case 13: valOddd += Convert.ToInt32(OddTable[c.ToString()]);  break;
                        
                    case 14: valEven += Convert.ToInt32(EvenTable[c.ToString()]); break;

                    case 15: valOddd += Convert.ToInt32(OddTable[c.ToString()]);  break;


                }

                counterVal += 1;
            }


            int totalValues = (valOddd + valEven) % 26;

            return RestsTable[totalValues.ToString()];




        }






     private string CalcCF(CFDataMembers cf)
      {

            string codice_completo = "";


            
            try
            {
                

                //Inizializza le tabelle
                EvenTable = new Dictionary<string, string>();
                OddTable = new Dictionary<string, string>();
                RestsTable = new Dictionary<string, string>();


                InitializeTables();


                int mm = cf.DataDiNascita.Month; 

            
                    cognome = cf.Cognome.ToArray(); 
                    nome = cf.Nome.ToArray(); 

                    //Controlla il giorno se sex è F o se è ad una sola cifra (<=9)
                    string dayBorn = "0";
                    int dayIfFemale = 0;

                    if (cf.Sesso.Equals("F"))
                    {
                        dayIfFemale = 40 + cf.DataDiNascita.Day;
                    }
                    else
                        dayIfFemale = cf.DataDiNascita.Day; 

                    if (dayIfFemale <= 9)
                    {
                        dayBorn += dayIfFemale.ToString();
                    }
                    else
                        dayBorn = dayIfFemale.ToString();




                    string code = SetCognome(cognome).ToUpper() + 
                                  SetNome(nome).ToUpper() + 
                                  cf.DataDiNascita.Year.ToString().Substring(cf.DataDiNascita.Year.ToString().Length -2,2) + 
                                  GetMonthCode(cf.DataDiNascita.Month.ToString()) + 
                                  dayBorn;


                   
                    code += cf.CodiceISTATComune; 

                    
                    //Check carattere di controllo
                    string ctrlChar = ControlCode(code);
                    code += ctrlChar;

                

                    //Free memory
                    EvenTable.Clear();
                    OddTable.Clear();
                    RestsTable.Clear();

                    EvenTable = null;
                    OddTable = null;
                    RestsTable = null;



                    codice_completo = code;

                

            }
            catch
            {
                codice_completo = "Error!";
            }

    




            return codice_completo;
      }







        



    }




}
