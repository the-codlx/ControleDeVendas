using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Vendas.br.com.projeto.model
{
    public class Helpers
    {

        public void LimparTela(Form tela)
        {
            foreach (Control ctrlPai in tela.Controls)
            {

                foreach (Control ctrl1 in ctrlPai.Controls)
                {
                    if (ctrl1 is TabPage)
                    {

                        foreach (Control crtl2 in ctrl1.Controls)
                        {

                            if (crtl2 is TextBox)
                            {
                                (crtl2 as TextBox).Text = string.Empty;
                            }

                            if (crtl2 is ComboBox)
                            {
                                (crtl2 as ComboBox).Text = string.Empty;
                            }

                            if (crtl2 is MaskedTextBox)
                            {
                                (crtl2 as MaskedTextBox).Text = string.Empty;
                            }

                        }

                    }

                }

            }

        }

    }

}
