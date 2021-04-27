using System.Collections.Generic;

namespace MeuAcerto.Selecao.KataGildedRose
{
    class GildedRose
    {
        IList<Item> Itens;
        public GildedRose(IList<Item> Itens)
        {
            this.Itens = Itens;
        }

        public void AtualizarQualidade()
        {
            for (var i = 0; i < Itens.Count; i++)
            {
                if (Itens[i].Nome != "Queijo Brie Envelhecido" && Itens[i].Nome != "Ingressos para o concerto do TAFKAL80ETC" && Itens[i].Nome != "Sulfuras, a Mão de Ragnaros" && Itens[i].Nome != "Bolo de Mana Conjurado")
                {
                    Itens[i].PrazoValidade = Itens[i].PrazoValidade - 1;
                    if (Itens[i].PrazoValidade < 0)
                    {
                        if (Itens[i].Qualidade <= 1)
                        {
                            Itens[i].Qualidade = 0;
                        }
                        else
                        {
                            Itens[i].Qualidade = Itens[i].Qualidade - 2;
                        }                     
                    }
                    else
                    {
                        if (Itens[i].Qualidade >= 1)
                        {
                            Itens[i].Qualidade = Itens[i].Qualidade - 1;
                        }                    
                    }
                }
                else
                {
                   if (Itens[i].Nome == "Queijo Brie Envelhecido")
                    {
                        Itens[i].PrazoValidade = Itens[i].PrazoValidade - 1;
                        if (Itens[i].Qualidade < 50)
                        {
                            if (Itens[i].PrazoValidade < 0)
                            {
                                if (Itens[i].Qualidade <= 48)
                                {
                                    Itens[i].Qualidade = Itens[i].Qualidade + 2;
                                }
                                else
                                {
                                    Itens[i].Qualidade = 50;
                                }
                            }
                            else
                            {
                                Itens[i].Qualidade = Itens[i].Qualidade + 1;
                            }
                        }                     
                    }
                    else if (Itens[i].Nome == "Ingressos para o concerto do TAFKAL80ETC")
                    {
                        Itens[i].PrazoValidade = Itens[i].PrazoValidade - 1;
                        if (Itens[i].PrazoValidade < 0)
                        {
                            Itens[i].Qualidade = 0;
                        }
                        else
                        {
                            if (Itens[i].Qualidade < 50)
                            {
                                if (Itens[i].PrazoValidade <= 5)
                                {
                                    if (Itens[i].Qualidade <= 47)
                                    {
                                        Itens[i].Qualidade = Itens[i].Qualidade + 3;
                                    }
                                    else
                                    {
                                        Itens[i].Qualidade = 50;
                                    }
                                }
                                else if (Itens[i].PrazoValidade <= 10)
                                {
                                    if (Itens[i].Qualidade <= 48)
                                    {
                                        Itens[i].Qualidade = Itens[i].Qualidade + 2;
                                    }
                                    else
                                    {
                                        Itens[i].Qualidade = 50;
                                    }
                                }
                                else
                                {
                                    Itens[i].Qualidade = Itens[i].Qualidade + 1;
                                }
                            }
                        }
                    }
                    else if (Itens[i].Nome == "Bolo de Mana Conjurado")
                    {
                        Itens[i].PrazoValidade = Itens[i].PrazoValidade - 1;
                        if (Itens[i].PrazoValidade < 0)
                        {
                            if (Itens[i].Qualidade <= 4)
                            {
                                Itens[i].Qualidade = 0;
                            }
                            else
                            {
                                Itens[i].Qualidade = Itens[i].Qualidade - 4;
                            }
                        }
                        else
                        {
                            if (Itens[i].Qualidade >= 2)
                            {
                                Itens[i].Qualidade = Itens[i].Qualidade - 2;
                            }
                        }
                    }
                }
            }
        }
    }
}
