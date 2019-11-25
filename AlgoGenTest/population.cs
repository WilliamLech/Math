using System;
using System.Collections.Generic;

public class Population
{
    List<Individu> pop = new List<Individu>();
    private Individu[] bestTab;

    public Population()
	{
        this.generatePop(100);
	}

    public Population(int nbIndividu)
    {
        this.generatePop(nbIndividu);
    }

    private void generatePop(int x)
    {
        for (int i = 0; i<x; i++)
        {
            this.pop.Add(new Individu());
        }
    }

    public String getPopTxt()
    {
        String res = "";
        foreach (Individu i in pop)
        {
            res += i.GenomeTxt();
        }
        return res; 
    }

    public String getPopScoreTxt()
    {
        String res = "";
        foreach (Individu i in pop)
        {
            res += i.ScoreTxt();
        }
        return res;
    }

    public void TrierPopu()
    {
       pop.Sort();
    }

    public void SetBestInidividu()
    {
        bestTab = new Individu[3];
        Individu[] poptrie = this.pop.ToArray();
        for (int i = 0; i < 3; i++)
        {
            this.bestTab[i] = poptrie[i];
        }
       // poptrie = null;
    }

    public String GetBest()
    {
        this.SetBestInidividu();
        String res = "";
        for (int i = 0; i < 3; i++)
        {
            Individu z = this.bestTab[i];
            res += z.getScoreTot() + "  "+z.GenomeTxt() + "\n";
        }
        return res;
    }

}
