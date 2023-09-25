using BacBo.Models;
using BacBo.Services;

namespace BacBo;

public partial class Form1 : Form
{
    private BacBoResult _bacBoResult;
    private readonly IBacBoService _bacBoService;

    public Form1(IBacBoService bacBoService)
    {
        InitializeComponent();
        _bacBoResult = new BacBoResult();
        _bacBoService = bacBoService;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        _bacBoResult.DrawDate = DateTime.Now;
        _bacBoResult.PlayerScore = 0;
        _bacBoResult.BankerScore = 0;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        _bacBoResult.PlayerFirstRoll = 1;
        label8.Text = "1";
        CalculateScores();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        _bacBoResult.PlayerFirstRoll = 2;
        label8.Text = "2";
        CalculateScores();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        _bacBoResult.PlayerFirstRoll = 3;
        label8.Text = "3";
        CalculateScores();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        _bacBoResult.PlayerFirstRoll = 4;
        label8.Text = "4";
        CalculateScores();
    }

    private void button5_Click(object sender, EventArgs e)
    {
        _bacBoResult.PlayerFirstRoll = 5;
        label8.Text = "5";
        CalculateScores();
    }

    private void button6_Click(object sender, EventArgs e)
    {
        _bacBoResult.PlayerFirstRoll = 6;
        label8.Text = "6";
        CalculateScores();
    }

    private void button7_Click(object sender, EventArgs e)
    {
        _bacBoResult.BankerFirstRoll = 1;
        label9.Text = "1";
        CalculateScores();
    }

    private void button8_Click(object sender, EventArgs e)
    {
        _bacBoResult.BankerFirstRoll = 2;
        label9.Text = "2";
        CalculateScores();
    }

    private void button9_Click(object sender, EventArgs e)
    {
        _bacBoResult.BankerFirstRoll = 3;
        label9.Text = "3";
        CalculateScores();
    }

    private void button10_Click(object sender, EventArgs e)
    {
        _bacBoResult.BankerFirstRoll = 4;
        label9.Text = "4";
        CalculateScores();
    }

    private void button11_Click(object sender, EventArgs e)
    {
        _bacBoResult.BankerFirstRoll = 5;
        label9.Text = "5";
        CalculateScores();
    }

    private void button12_Click(object sender, EventArgs e)
    {
        _bacBoResult.BankerFirstRoll = 6;
        label9.Text = "6";
        CalculateScores();
    }

    private void button13_Click(object sender, EventArgs e)
    {
        _bacBoResult.PlayerSecondRoll = 1;
        label10.Text = "1";
        CalculateScores();
    }

    private void button14_Click(object sender, EventArgs e)
    {
        _bacBoResult.PlayerSecondRoll = 2;
        label10.Text = "2";
        CalculateScores();
    }

    private void button15_Click(object sender, EventArgs e)
    {
        _bacBoResult.PlayerSecondRoll = 3;
        label10.Text = "3";
        CalculateScores();
    }

    private void button16_Click(object sender, EventArgs e)
    {
        _bacBoResult.PlayerSecondRoll = 4;
        label10.Text = "4";
        CalculateScores();
    }

    private void button17_Click(object sender, EventArgs e)
    {
        _bacBoResult.PlayerSecondRoll = 5;
        label10.Text = "5";
        CalculateScores();
    }

    private void button18_Click(object sender, EventArgs e)
    {
        _bacBoResult.PlayerSecondRoll = 6;
        label10.Text = "6";
        CalculateScores();
    }

    private void button19_Click(object sender, EventArgs e)
    {
        _bacBoResult.BankerSecondRoll = 1;
        label11.Text = "1";
        CalculateScores();
    }

    private void button20_Click(object sender, EventArgs e)
    {
        _bacBoResult.BankerSecondRoll = 2;
        label11.Text = "2";
        CalculateScores();
    }

    private void button21_Click(object sender, EventArgs e)
    {
        _bacBoResult.BankerSecondRoll = 3;
        label11.Text = "3";
        CalculateScores();
    }

    private void button22_Click(object sender, EventArgs e)
    {
        _bacBoResult.BankerSecondRoll = 4;
        label11.Text = "4";
        CalculateScores();
    }

    private void button23_Click(object sender, EventArgs e)
    {
        _bacBoResult.BankerSecondRoll = 5;
        label11.Text = "5";
        CalculateScores();
    }

    private void button24_Click(object sender, EventArgs e)
    {
        _bacBoResult.BankerSecondRoll = 6;
        label11.Text = "6";
        CalculateScores();
    }

    private void CalculateScores()
    {
        _bacBoResult.PlayerScore = _bacBoResult.PlayerFirstRoll + _bacBoResult.PlayerSecondRoll;
        _bacBoResult.BankerScore = _bacBoResult.BankerFirstRoll + _bacBoResult.BankerSecondRoll;

        double playerScorePercentage = (double)_bacBoResult.PlayerScore / 12 * 100;
        double bankerScorePercentage = (double)_bacBoResult.BankerScore / 12 * 100;

        int playerScore = (int)playerScorePercentage;
        int bankerScore = (int)bankerScorePercentage;

        progressBar1.Value = playerScore;
        progressBar2.Value = bankerScore;
    }

    private void button25_Click(object sender, EventArgs e)
    {
        if (_bacBoResult.PlayerScore == _bacBoResult.BankerScore)
            _bacBoResult.Tie = true;

        if (_bacBoResult.PlayerScore > _bacBoResult.BankerScore)
            _bacBoResult.PlayerWins = true;

        if (_bacBoResult.BankerScore > _bacBoResult.PlayerScore)
            _bacBoResult.BankerWins = true;

        _bacBoResult.Source = "Betway Evolution Bac Bo";

        label7.Text = $"Date: {_bacBoResult.DrawDate}\n" +
            $"PlayerFirstRoll: {_bacBoResult.PlayerFirstRoll}\n" +
            $"BankerFirstRoll: {_bacBoResult.BankerFirstRoll}\n" +
            $"PlayerSecondRoll: {_bacBoResult.PlayerSecondRoll}\n" +
            $"BankerSecondRoll: {_bacBoResult.BankerSecondRoll}\n" +
            $"PlayerScore: {_bacBoResult.PlayerScore}\n" +
            $"BankerScore: {_bacBoResult.BankerScore}\n" +
            $"PlayerWins: {_bacBoResult.PlayerWins}\n" +
            $"BankerWins: {_bacBoResult.BankerWins}\n" +
            $"Tie: {_bacBoResult.Tie}\n" +
            $"Source: {_bacBoResult.Source}";
    }
}