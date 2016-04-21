using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodyMassIndex
{
    public partial class BodyMassIndexForm : Form
    {
        //images array+++++++++++++++++++++++++++++++++++++++++++++
        private Bitmap[] _imageArrayM = {Properties.Resources.underweightM, 
                                        Properties.Resources.healthWeightM,
                                        Properties.Resources.overweightM,
                                        Properties.Resources.obeseM};
        private Bitmap[] _imageArrayFe = {Properties.Resources.underweightFe, 
                                        Properties.Resources.healthWeightFe,
                                        Properties.Resources.overweightFe,
                                        Properties.Resources.obeseFe};
       


        public BodyMassIndexForm()
        {
            InitializeComponent();
        }

        //Calculate Button+++++++++++++++++++++++++++++++++++++++++++++
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //declear local variables
            double height, weight, chest, bMI, cMI;

            try
            {
                //convert to numbers
                height = Convert.ToDouble(HeightTextBox.Text);
                weight = Convert.ToDouble(WeightTextBox.Text);
               
                //each textbox can't be empty
                if (HeightTextBox.Text==""||WeightTextBox.Text=="")
                {
                    MessageBox.Show("All the text box can't be empty!");
                }

                //height or weight can't be negative or zero
                else if (height<=0||weight<=0)
                {
                    MessageBox.Show("Height or Weight can't be negative or zero!");
                    HeightTextBox.Focus();
                    HeightTextBox.SelectAll();
                }
                else if (height>0||weight>0)
                {
                    
                    //when calculated, desable inputed textboxes
                    HeightTextBox.Enabled = false;
                    WeightTextBox.Enabled = false;
                    ChestTextBox.Enabled = false;

                    //calculates the BMI for Male
                    if (MaleRadioButton.Checked==true)
                    {
                        //algorithm
                        bMI = weight / ((height/100) * (height/100));
                        BMITextBox.Text = Convert.ToString(bMI);


                        //detarmine BMI
                        if (bMI<18.5)
                        {
                            PictureBox.Image = this._imageArrayM[0];
                            MessageBox.Show("Underweight < 18.5");
                        }
                        else if (bMI>=18.5&&bMI<=24.9)
                        {
                            PictureBox.Image = this._imageArrayM[1];
                            MessageBox.Show("Normal weight = 18.5~24.9 ");
                        }
                        else if (bMI>25&&bMI<=29.9)
                        {
                            PictureBox.Image = this._imageArrayM[2];
                            MessageBox.Show("Overweight = 25~29.9");
                        }
                        else if (bMI>=30)
                        {
                            PictureBox.Image = this._imageArrayM[3];
                            MessageBox.Show("Obesity >= 30");
                        }

                    }
                    //calculates the BMI for Female
                    else if (FemaleRadioButton.Checked==true)
                    {
                        //algorithm
                        bMI = weight / ((height / 100) * (height / 100));
                        BMITextBox.Text = Convert.ToString(bMI);

                        //claculate cMI
                        chest = Convert.ToDouble(ChestTextBox.Text);
                        cMI = chest / height;
                        CMITextBox.Text = Convert.ToString(cMI);

                        //detarmine BMI
                        if (bMI < 18.5)
                        {
                            PictureBox.Image = this._imageArrayFe[0];
                            MessageBox.Show("Underweight < 18.5");
                        }
                        else if (bMI >= 18.5 && bMI <= 24.9)
                        {
                            PictureBox.Image = this._imageArrayFe[1];
                            MessageBox.Show("Normal weight = 18.5~24.9 ");
                        }
                        else if (bMI > 25 && bMI <= 29.9)
                        {
                            PictureBox.Image = this._imageArrayFe[2];
                            MessageBox.Show("Overweight = 25~29.9");
                        }
                        else if (bMI >= 30)
                        {
                            PictureBox.Image = this._imageArrayFe[3];
                            MessageBox.Show("Obesity >= 30");
                        }
                        
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You must fill all the forms, and Height, Weight can't be less or equal to 0");
                HeightTextBox.Focus();
                HeightTextBox.SelectAll();
            }
        }

        //Female button actived
        private void FemaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //chest textbox enable
            ChestTextBox.Enabled = true;
            
            //chest textbox desiable
            if (MaleRadioButton.Checked==true)
            {
                ChestTextBox.Enabled = false;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //clear all
            HeightTextBox.Text = "";
            WeightTextBox.Text = "";
            ChestTextBox.Text = "";
            BMITextBox.Text = "";
            CMITextBox.Text = "";

            //enable all the textbox
            HeightTextBox.Enabled = true;
            WeightTextBox.Enabled = true;

            //picture box
            PictureBox.Image = Properties.Resources.skinnyGirl;

            //male checked should dasiable the chest text box
            if (MaleRadioButton.Checked==true)
            {
                ChestTextBox.Enabled = false;
            }
            else
            {
                ChestTextBox.Enabled = true;
            }
        }
        //switch languages
        private void ChineseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActiveForm.Text = Properties.Resources.TitleFormCH;
            LanguagesGroupBox.Text = Properties.Resources.LanguagesGroupBoxCH;
            GenderGroupBox.Text = Properties.Resources.GenderGroupBoxCH;
            MaleRadioButton.Text = Properties.Resources.MaleRadioButtonCH;
            FemaleRadioButton.Text = Properties.Resources.FemaleRadioButtonCH;
            HeightLabel.Text = Properties.Resources.HeightLabelCH;
            WeightLabel.Text = Properties.Resources.WeightLabelCH;
            ChestLabel.Text = Properties.Resources.ChestLabelCH;
            BMILabel.Text = Properties.Resources.BMILabelCH;
            CMILabel.Text = Properties.Resources.CMILabelCH;
            BMIGroupBox.Text = Properties.Resources.BMILabelCH;
            CMIGroupBox.Text = Properties.Resources.CMILabelCH;
            UnderwightLabel.Text = Properties.Resources.UnderwightLabelCH;
            NormalLabel.Text = Properties.Resources.NormalLabelCH;
            OverweightLabel.Text = Properties.Resources.OverweightLableCH;
            ObesityLabel.Text = Properties.Resources.ObesityLabelCH;
            SamllLabel.Text = Properties.Resources.SamllLabelCH;
            StandardLabel.Text = Properties.Resources.StandardLabelCH;
            PerfectLabel.Text = Properties.Resources.PerfectLabelCH;
            TooBigLabel.Text = Properties.Resources.TooBigLabelCH;
            CalculateButton.Text = Properties.Resources.CalculateButtonCH;
            ClearButton.Text = Properties.Resources.ClearButtonCH;
        }

        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActiveForm.Text = Properties.Resources.TitleFormE;
            LanguagesGroupBox.Text = Properties.Resources.LanguagesGroupBoxE;
            GenderGroupBox.Text = Properties.Resources.GenderGroupBoxE;
            MaleRadioButton.Text = Properties.Resources.MaleRadioButtonE;
            FemaleRadioButton.Text = Properties.Resources.FemaleRadioButtonE;
            HeightLabel.Text = Properties.Resources.HeightLabelE;
            WeightLabel.Text = Properties.Resources.WeightLabelE;
            ChestLabel.Text = Properties.Resources.ChestLabelE;
            BMILabel.Text = Properties.Resources.BMILabelE;
            CMILabel.Text = Properties.Resources.CMILabelE;
            BMIGroupBox.Text = Properties.Resources.BMILabelE;
            CMIGroupBox.Text = Properties.Resources.CMILabelE;
            UnderwightLabel.Text = Properties.Resources.UnderwightLabelE;
            NormalLabel.Text = Properties.Resources.NormalLabelE;
            OverweightLabel.Text = Properties.Resources.OverweightLableE;
            ObesityLabel.Text = Properties.Resources.ObesityLabelE;
            SamllLabel.Text = Properties.Resources.SamllLabelE;
            StandardLabel.Text = Properties.Resources.StandardLabelE;
            PerfectLabel.Text = Properties.Resources.PerfectLabelE;
            TooBigLabel.Text = Properties.Resources.TooBigLabelE;
            CalculateButton.Text = Properties.Resources.CalculateButtonE;
            ClearButton.Text = Properties.Resources.ClearButtonE;
        }
    }
}
