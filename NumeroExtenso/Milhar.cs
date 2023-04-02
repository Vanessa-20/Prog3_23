namespace NumeroExtenso
{
    public class Milhar
    {
        public string MilharPorExtenso (int numero) 
        {
            string retorno ="";
            Unidade unidade = new Unidade();

            if (numero>999 && numero<2000)
                return "um mil ";
            
            if (numero>1999 && numero<3000)
                return "dois mil ";
                
            if (numero>2999 && numero<4000)
                return "três mil ";
            
            if (numero>3999 && numero<5000)
                return "quatro mil";
                
            if (numero>4999 && numero<6000)
                return "cinco mil ";
                
            if (numero>5999 && numero<7000)
                return "seis mil ";
                
            if (numero>6999 && numero<8000)
                return "sete mil ";
                
            if (numero>7999 && numero<9000)
                return "oito mil ";

            if (numero>8999 && numero<10000)
                return "nove mil ";    
            else
        
            if (numero>=999 && numero<2000)
            {
                if (numero ==999)
                    return " um mil ";
                else 
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = " um mil e ";
                    retorno +=  centena.CentenaPorExtenso(Convert.ToInt32(und));
                }    
                return retorno;
            }
            
            if (numero>1999 && numero<2000)
            {
                if (numero ==2000)
                    return "dois mil";
                else 
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "dois mil e ";
                    retorno +=  centena.CentenaPorExtenso(Convert.ToInt32(und));
                }    
                return retorno;
            }
                
            if (numero>=2999 && numero<4000)
            {
                if (numero ==3000)
                    return "três mil";
                else 
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "três mil e ";
                    retorno +=  centena.CentenaPorExtenso(Convert.ToInt32(und));
                }    
                return retorno;
            }
            
            if (numero>=3999 && numero<5000)
            {
                if (numero ==4000)
                    return "quatro mil";
                else 
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "quatro mil e ";
                    retorno +=  centena.CentenaPorExtenso(Convert.ToInt32(und));
                }    
                return retorno;
            }
                
            if (numero>=4999 && numero<6000)
            {
                if (numero ==5000)
                    return "cinco mil";
                else 
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "cinco mil e ";
                    retorno +=  centena.CentenaPorExtenso(Convert.ToInt32(und));
                }    
                return retorno;
            }
                
            if (numero>=5999 && numero<7000)
            {
                if (numero ==6000)
                    return "seis mil";
                else 
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "seis mil e ";
                    retorno +=  centena.CentenaPorExtenso(Convert.ToInt32(und));
                }    
                return retorno;
            }
                
            if (numero>=6999 && numero<8000)
            {
                if (numero ==7000)
                    return "sete mil";
                else 
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "sete mil e ";
                    retorno +=  centena.CentenaPorExtenso(Convert.ToInt32(und));
                }    
                return retorno;
            }
                
            if (numero>=7999 && numero<9000)
                {
                if (numero ==8000)
                    return "oito mil";
                else 
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "oito mil e ";
                    retorno +=  centena.CentenaPorExtenso(Convert.ToInt32(und));
                }    

                if (numero>=8999 && numero<1000)
            {
                if (numero ==9000)
                    return "nove mil";
                else 
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "nove mil e ";
                    retorno +=  centena.CentenaPorExtenso(Convert.ToInt32(und));
                }    
                return retorno;
            }
                return "número inválido";
    }
}
}