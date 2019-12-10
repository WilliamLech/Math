using System;

public class Individu : IComparable<Individu>
{
    private double vitesse;
    private double detec;
    private double energie;
    private double taille;
    private static readonly double mutate = 0.10; 

    public Individu()
	{
        Random rdm = new Random();
        this.vitesse = rdm.NextDouble() * 100;
        this.detec = rdm.NextDouble() * 10;
        this.energie = rdm.NextDouble() * 1000;
        this.taille = rdm.NextDouble() * 10;
	}

    public String GenomeTxt()
    {
        return "vitesse = " + this.vitesse.ToString()+"  detection = " + this.detec.ToString() + " energie = " + this.energie.ToString() + " taille = "+this.taille.ToString() + " \n";
    }

    public String ScoreTxt()
    {
        return getScoreTot().ToString()  +" \n";
    }

    public double getScoreTot()
    {
        return this.vitesse + this.energie + this.taille + this.detec;
    }

    public int CompareTo(Individu other)
    {
        if (this.getScoreTot() >= other.getScoreTot())
        {
            return -1;
        }
        else
        {
            return 1;
        }
    }

    private void mutation()
    {
        Random rdm = new Random();
        if (rdm.NextDouble() < mutate)
        {
            this.detec += RdmInterval(5);
        }
        if (rdm.NextDouble() < mutate)
        {
            this.taille += RdmInterval(10);
        }
        if (rdm.NextDouble() < mutate)
        {
            this.vitesse += RdmInterval(10);
        }
        if (rdm.NextDouble() < mutate)
        {
            this.energie += RdmInterval(10);
        }
    }
    
    private  double RdmInterval(double max)
    {
        Random rdm = new Random();
        if (max < 1 )
        {
            return rdm.NextDouble();
        }
        double res = (rdm.NextDouble()*(max));
        double sign = rdm.NextDouble();
        if (sign > 0.5)
        {
            res = -res;  
        }
        return res;
    }

}
