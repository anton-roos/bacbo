using BacBo.Models;
using BacBo.Services;

namespace BacBo;

public partial class Home : Form
{
    private BacBoResult _bacBoResult;
    private readonly IBacBoService _bacBoService;

    public Home(IBacBoService bacBoService)
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
        int playerScore = _bacBoResult.PlayerFirstRoll + _bacBoResult.PlayerSecondRoll;
        int bankerScore = _bacBoResult.BankerFirstRoll + _bacBoResult.BankerSecondRoll;

        label7.Text = playerScore.ToString();
        label12.Text = bankerScore.ToString();

        _bacBoResult.PlayerScore = playerScore;
        _bacBoResult.BankerScore = bankerScore;

        double playerScorePercentageCalculated = (double)_bacBoResult.PlayerScore / 12 * 100;
        double bankerScorePercentageCalculated = (double)_bacBoResult.BankerScore / 12 * 100;

        int playerScorePercentage = (int)playerScorePercentageCalculated;
        int bankerScorePercentage = (int)bankerScorePercentageCalculated;

        progressBar1.Value = playerScorePercentage;
        progressBar2.Value = bankerScorePercentage;
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

        _bacBoService.StoreBacBoResult(_bacBoResult);
        ClearLabels();
        _bacBoResult = new BacBoResult
        {
            DrawDate = DateTime.Now,
            PlayerScore = 0,
            BankerScore = 0,
        };
    }

    private void ClearLabels()
    {
        label7.Text = "";
        label8.Text = "";
        label9.Text = "";
        label10.Text = "";
        label11.Text = "";
        label12.Text = "";
        progressBar1.Value = 0;
        progressBar2.Value = 0;
    }

    private void button26_Click(object sender, EventArgs e)
    {
        var itemList = _bacBoService.GetAllBacBoResults();

        foreach (var item in itemList)
        {
            var winner = "";
            if (item.PlayerWins) winner = "P";
            if (item.BankerWins) winner = "B";
            if (item.Tie) winner = "T";
            listBox1.Items.Add($"{winner}, {item.PlayerFirstRoll}, {item.BankerFirstRoll}, " +
                $"{item.PlayerSecondRoll}, {item.BankerSecondRoll}, {item.PlayerScore}, " +
                $"{item.BankerScore}");
        }
    }

    private void button27_Click(object sender, EventArgs e)
    {
        var itemList = _bacBoService.GetAllBacBoResults();

        var PlayerRollOneOneCount = itemList.Where(x => x.PlayerFirstRoll == 1).ToList().Count.ToString();
        var PlayerRollOneTwoCount = itemList.Where(x => x.PlayerFirstRoll == 2).ToList().Count.ToString();
        var PlayerRollOneThreeCount = itemList.Where(x => x.PlayerFirstRoll == 3).ToList().Count.ToString();
        var PlayerRollOneFourCount = itemList.Where(x => x.PlayerFirstRoll == 4).ToList().Count.ToString();
        var PlayerRollOneFiveCount = itemList.Where(x => x.PlayerFirstRoll == 5).ToList().Count.ToString();
        var PlayerRollOneSixCount = itemList.Where(x => x.PlayerFirstRoll == 6).ToList().Count.ToString();

        var PlayerRollTwoOneCount = itemList.Where(x => x.PlayerSecondRoll == 1).ToList().Count.ToString();
        var PlayerRollTwoTwoCount = itemList.Where(x => x.PlayerSecondRoll == 2).ToList().Count.ToString();
        var PlayerRollTwoThreeCount = itemList.Where(x => x.PlayerSecondRoll == 3).ToList().Count.ToString();
        var PlayerRollTwoFourCount = itemList.Where(x => x.PlayerSecondRoll == 4).ToList().Count.ToString();
        var PlayerRollTwoFiveCount = itemList.Where(x => x.PlayerSecondRoll == 5).ToList().Count.ToString();
        var PlayerRollTwoSixCount = itemList.Where(x => x.PlayerSecondRoll == 6).ToList().Count.ToString();

        var BankerRollOneOneCount = itemList.Where(x => x.BankerFirstRoll == 1).ToList().Count.ToString();
        var BankerRollOneTwoCount = itemList.Where(x => x.BankerFirstRoll == 2).ToList().Count.ToString();
        var BankerRollOneThreeCount = itemList.Where(x => x.BankerFirstRoll == 3).ToList().Count.ToString();
        var BankerRollOneFourCount = itemList.Where(x => x.BankerFirstRoll == 4).ToList().Count.ToString();
        var BankerRollOneFiveCount = itemList.Where(x => x.BankerFirstRoll == 5).ToList().Count.ToString();
        var BankerRollOneSixCount = itemList.Where(x => x.BankerFirstRoll == 6).ToList().Count.ToString();

        var BankerRollTwoOneCount = itemList.Where(x => x.BankerSecondRoll == 1).ToList().Count.ToString();
        var BankerRollTwoTwoCount = itemList.Where(x => x.BankerSecondRoll == 2).ToList().Count.ToString();
        var BankerRollTwoThreeCount = itemList.Where(x => x.BankerSecondRoll == 3).ToList().Count.ToString();
        var BankerRollTwoFourCount = itemList.Where(x => x.BankerSecondRoll == 4).ToList().Count.ToString();
        var BankerRollTwoFiveCount = itemList.Where(x => x.BankerSecondRoll == 5).ToList().Count.ToString();
        var BankerRollTwoSixCount = itemList.Where(x => x.BankerSecondRoll == 6).ToList().Count.ToString();

        proll1frequency.Text = PlayerRollOneOneCount;
    }

    private void label13_Click(object sender, EventArgs e)
    {

    }
}