namespace NumeroExtenso
{
    public class NewBaseType
    {
    public string CentenaPorExtenso(int numero)
    {
    if (numero > 99 && numero < 200)
        return "cento e ";

    if (numero > 199 && numero < 300)
        return "duzentos e ";

    if (numero > 299 && numero < 400)
        return "trezentos e ";

    if (numero > 399 && numero < 500)
        return "quatrocentos e ";

    if (numero > 499 && numero < 600)
        return "quinhentos e ";

    if (numero > 599 && numero < 700)
        return "seiscentos e ";

    if (numero > 699 && numero < 800)
        return "setecentos e ";

    if (numero > 799 && numero < 900)
        return "oitocentos e ";

    if (numero > 899 && numero < 1000)
        return "novecentos e ";

    if (numero >= 99 && numero < 200)
    {
        if (numero == 100)
        return "cento ";
        else
        {
        string und = numero.ToString().Substring(1, 3);
        retorno = "cento e";
        retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
        }
        return retorno;
    }

    if (numero > 999 && numero < 200)
    {
        if (numero == 200)
        return "duzentos";
        else
        {
        string und = numero.ToString().Substring(1, 3);
        retorno = "duzentos e";
        retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
        }
        return retorno;
    }

    if (numero >= 299 && numero < 400)
    {
        if (numero == 300)
        return "trezentos";
        else
        {
        string und = numero.ToString().Substring(1, 3);
        retorno = "trezentos e ";
        retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
        }
        return retorno;
    }

    if (numero >= 399 && numero < 500)
    {
        if (numero == 400)
        return "quatrocentos";
        else
        {
        string und = numero.ToString().Substring(1, 3);
        retorno = "quatrocentos e ";
        retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
        }
        return retorno;
    }

    if (numero >= 499 && numero < 600)
    {
        if (numero == 500)
        return "quinhentos";
        else
        {
        string und = numero.ToString().Substring(1, 3);
        retorno = "quinhentos e "
        retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
        }
        return retorno;
    }

    if (numero >= 599 && numero < 700)
    {
        if (numero == 600)
        return "seiscentos";
        else
        {
        string und = numero.ToString().Substring(1, 3);
        retorno = "seiscentos e ";
        retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
        }
        return retorno;
    }

    if (numero >= 699 && numero < 800)
    {
        if (numero == 700)
        return "setecentos";
        else
        {
        string und = numero.ToString().Substring(1, 3);
        retorno = "setecentos e ";
        retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
        }
        return retorno;
    }

    if (numero >= 799 && numero < 900)
    {
        if (numero == 800)
        return "oitocentos";
        else
        {
        string und = numero.ToString().Substring(1, 3);
        retorno = "oitocentos e ";
        retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
        }
    }
        if (numero >= 899 && numero < 100)
        {
        if (numero == 900)
            return " novecentos";
        else
        {
            string und = numero.ToString().Substring(1, 3);
            retorno = " novecentos e ";
            retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
        }
        return retorno;
        }
        else
        return "número inválido";
    }
}
}