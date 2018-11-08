using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpelarPortalenMVC1.Models;


namespace SpelarPortalenMVC1.Controllers
{
    public class HomeController : Controller
    {
        // establish db connect from azure
        FootyDBEntities pwdb = new FootyDBEntities();

        // GET: Home
        public ActionResult LoginPage()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult LoginPage(User user)
        {
            if (user.Username == null || user.Password == null)
            {
                ModelState.AddModelError("", "Enter both username and password to proceed!");
                return View();
            }
            bool validUser = false;

            validUser = CheckUser(user.Username, user.Password);

            if (validUser == true)
            {
                System.Web.Security.FormsAuthentication.RedirectFromLoginPage(user.Username, false);
            }
            ModelState.AddModelError("", "Incorrect login!");
            return View();
        }

        [Authorize]
        public ActionResult Start()
        {
            // temp lists
            List<Player> playerList = new List<Player>();
            List<CurrentSquad> squad = new List<CurrentSquad>();

            // all players to list
            List<Player> fullSquad = new List<Player>();

            // try to add new user
            try
            {
                // create full squad to list
                foreach (var item in pwdb.Players)
                {
                    Player tempUser = new Player();

                    tempUser.PlayerId = item.PlayerId;
                    tempUser.FirstName = item.FirstName;
                    tempUser.Surname = item.Surname;
                    tempUser.Position = item.Position;
                    tempUser.ShirtNumber = item.ShirtNumber;

                    playerList.Add(tempUser);
                }
            }
            catch
            {
                Player tempUser = new Player();
                tempUser.PlayerId = 0;
                tempUser.FirstName = "No players in DB";
                tempUser.Surname = "No players in DB";
                tempUser.Position = "No players in DB";
                tempUser.ShirtNumber = 0;

                playerList.Add(tempUser);
            }


            try
            {
                // create only selected squad
                foreach (var item in pwdb.CurrentSquads)
                {
                    CurrentSquad tempSquadPlayer = new CurrentSquad();

                    tempSquadPlayer.IdPlayer = item.IdPlayer;

                    squad.Add(tempSquadPlayer);
                }
            }
            catch
            {
                CurrentSquad tempSquadPlayer = new CurrentSquad();

                tempSquadPlayer.IdPlayer = 0;

                squad.Add(tempSquadPlayer);
            }

            // try to get full squad to page
            try
            {
                // delete entries that were not picked, only add currentSquad to sent to view later
                foreach (var item in squad)
                {
                    for (int i = 0; i < playerList.Count; i++)
                    {
                        if (item.IdPlayer == playerList[i].PlayerId)
                        {
                            Player tempUser = new Player();

                            tempUser.FirstName = playerList[i].FirstName;
                            tempUser.Surname = playerList[i].Surname;
                            tempUser.Position = playerList[i].Position;
                            tempUser.ShirtNumber = playerList[i].ShirtNumber;

                            fullSquad.Add(tempUser);
                        }
                        else
                        {
                            // dont add to new list
                        }
                    }

                }
            }
            // give error players to table, saying no players in db
            catch
            {
                Player errorPlayer = new Player()
                {
                    FirstName = "No players found in DB",
                    Surname = "No players found in DB",
                    Position = "No players found in DB",
                    ShirtNumber = 0
                };
                fullSquad.Add(errorPlayer);
            }

            // create squadlist and sort it
            List<Player> completeSquadListSorted = new List<Player>();
            completeSquadListSorted = fullSquad.OrderBy(x => x.Position).ToList();

            // create list for all games for team
            List <Fixture> allGamesForTeam = new List<Fixture>();

            // fixture home/away create
            Fixture firstMatchFixtureHome = new Fixture();
            Fixture firstMatchFixtureAway = new Fixture();

            // try to add fixture to list - to be aware of nulls
            try
            {
                // add fixtures to list
                allGamesForTeam.AddRange(pwdb.Fixtures.Where(x => x.TeamHomeId == 1));
                allGamesForTeam.AddRange(pwdb.Fixtures.Where(x => x.TeamAwayId == 1));

                // sort list
                allGamesForTeam.OrderByDescending(x => x.Date);

                // get value for next home-away games
                firstMatchFixtureHome = pwdb.Fixtures.Where(y => y.Result == "TBA").First(x => x.TeamHomeId == 1);
                firstMatchFixtureAway = pwdb.Fixtures.Where(y => y.Result == "TBA").First(x => x.TeamAwayId == 1);
            }
            // return errors fixture if model = null or no contact
            catch
            {
                Fixture fixtureError = new Fixture()
                {
                    TeamHomeId = 0,
                    TeamAwayId = 0,
                    Result = "NO FIXTURES FOUND IN DB",
                    Referee = "NO FIXTURES FOUND IN DB",
                    FixtureId = 0,
                    Date = DateTime.Now
                };
                // return error if empty
                allGamesForTeam.Add(fixtureError);
                firstMatchFixtureHome = fixtureError;
                firstMatchFixtureAway = fixtureError;
            }

            // list for surte fixtures (will only add surtes)
            List<AllFixtures> allFixtureList = new List<AllFixtures>();
            // try to get fixture games for SURTE ONLY 
            try
            {
                // get fixtures
                var joinedTablesAway = from t1 in pwdb.Fixtures
                                       join t2 in pwdb.Teams on t1.TeamHomeId equals t2.TeamId
                                       join t3 in pwdb.Teams on t1.TeamAwayId equals t3.TeamId
                                       select new { teamHomeName = t2.TeamName, teamAwayName = t3.TeamName, t2.ArenaName, t1.Date, t1.Result, t1.Referee };

                foreach (var item in joinedTablesAway)
                {
                    AllFixtures tempFix = new AllFixtures();

                    tempFix.JHomeTeamName = item.teamHomeName;
                    tempFix.JAwayTeamName = item.teamAwayName;

                    tempFix.JDate = item.Date;
                    tempFix.JResult = item.Result;
                    tempFix.JReferee = item.Referee;
                    tempFix.JArena = item.ArenaName;


                    // only add if surte plays the game
                    if (tempFix.JHomeTeamName == "Surte IS FK" || tempFix.JAwayTeamName == "Surte IS FK")
                    {
                        allFixtureList.Add(tempFix);
                    }
                }
            }
            // add error data to display to user
            catch
            {
                AllFixtures tempFix = new AllFixtures();

                tempFix.JHomeTeamName = "COULDNT REACH DB!";
                tempFix.JAwayTeamName = "COULDNT REACH DB!";

                tempFix.JDate = DateTime.Now;
                tempFix.JResult = "COULDNT REACH DB!";
                tempFix.JReferee = "COULDNT REACH DB!";
                tempFix.JArena = "COULDNT REACH DB!";

                allFixtureList.Add(tempFix);
            }

            // create viewmodel reference
            MatchDayModel viewModel = new MatchDayModel();


            // set model = data to be passed
            
            // squad
            viewModel.squadPlayers = completeSquadListSorted;

            // next home fixure
            viewModel.FixtureHome = firstMatchFixtureHome;

            // next away fixture
            viewModel.FixtureAway = firstMatchFixtureAway;

            // all team games
            viewModel.TeamGames = allGamesForTeam;

            // add fixturelist joined
            viewModel.FixtureList = allFixtureList;
          
            // send full squad, sorted list to view to display
            return View(viewModel);
        }

        [Authorize]
        public ActionResult MyProfile()
        {
            List<Player> AllPlayers = new List<Player>();

            // try to give stat 
            try
            {
                // give stats for each player to model
                foreach (var item in pwdb.Players)
                {

                    Player tempPlayer = new Player();

                    tempPlayer.TeamId = item.TeamId;
                    tempPlayer.FirstName = item.FirstName;
                    tempPlayer.Surname = item.Surname;
                    tempPlayer.BirthDate = item.BirthDate.Date;
                    tempPlayer.Position = item.Position;
                    tempPlayer.ShirtNumber = item.ShirtNumber;

                    tempPlayer.YellowCards = item.YellowCards;
                    tempPlayer.RedCards = item.RedCards;
                    tempPlayer.Injured = item.Injured;

                    tempPlayer.Goals = item.Goals;
                    tempPlayer.Assists = item.Assists;

                    // if player is in surte-team - add him to surte-list
                    if (tempPlayer.TeamId == 1)
                    {
                        AllPlayers.Add(tempPlayer);
                    }
                }
            }
            // return error model if not available
            catch
            {
                Player tempPlayer = new Player();

                tempPlayer.TeamId = 1;
                tempPlayer.FirstName = "Error no players found in DB"; 
                tempPlayer.Surname = "Error no players found in DB";
                tempPlayer.BirthDate = DateTime.Now;
                tempPlayer.Position = "Error no players found in DB";
                tempPlayer.ShirtNumber = 0;

                tempPlayer.YellowCards = 0;
                tempPlayer.RedCards = 0;
                tempPlayer.Injured = false;

                tempPlayer.Goals = 0;
                tempPlayer.Assists = 0;

                // if player is in surte-team - add him to surte-list
                if (tempPlayer.TeamId == 1)
                {
                    AllPlayers.Add(tempPlayer);
                }
            }


            // add players to list to be sorted
            List<Player> sortedList = new List<Player>();

            // sort
            sortedList = AllPlayers.OrderBy(x => x.Position).ToList();

            return View(sortedList);
        }

        [Authorize]
        public ActionResult Table()
        {
            // create a list to keep teams in from created special class
            List<TeamInTable> teamStatsList = new List<TeamInTable>();

            // try to do this, add and send to view
            try
            {
                // get tableData with linq
                var joinedTablesRank = from t1 in pwdb.RankingTables
                                       join t2 in pwdb.Teams on t1.TeamId equals t2.TeamId
                                       select new { t2.TeamName, t1.PlayedGames, t1.WonGames, t1.DrawGames, t1.LostGames, t1.Points };

                // get put in data in list with foreach from linq
                foreach (var item in joinedTablesRank)
                {
                    TeamInTable tempTeam = new TeamInTable();

                    tempTeam.TName = item.TeamName;
                    tempTeam.TPlayerGames = item.PlayedGames;
                    tempTeam.TWins = item.WonGames;
                    tempTeam.TDraw = item.DrawGames;
                    tempTeam.TLost = item.LostGames;
                    tempTeam.TPoints = item.Points;

                    teamStatsList.Add(tempTeam);
                }
            }
            // didnt work? add prop-error data to display to user
            catch
            {
                // add error data to display to user
                TeamInTable tempTeam = new TeamInTable();

                tempTeam.TName = "Error, could not reach DB!";
                tempTeam.TPlayerGames = 0;
                tempTeam.TWins = 0;
                tempTeam.TDraw = 0;
                tempTeam.TLost = 0;
                tempTeam.TPoints = 0;

                teamStatsList.Add(tempTeam);
            }
         
            // access viewmodel
            TableLeagueVM viewModel = new TableLeagueVM();
            
            // list with teams, add to viewmodel
            viewModel.TeamLists = teamStatsList;

            return View(viewModel);
        }

        [Authorize]
        public ActionResult Fixtures()
        {
            // list for surte fixtures (will only add surtes)
            List<AllFixtures> allFixtureList = new List<AllFixtures>();

            // try to get fixture games for SURTE ONLY 
            try
            {
                // get fixtures
                var joinedTablesAway = from t1 in pwdb.Fixtures
                                       join t2 in pwdb.Teams on t1.TeamHomeId equals t2.TeamId
                                       join t3 in pwdb.Teams on t1.TeamAwayId equals t3.TeamId
                                       select new { teamHomeName = t2.TeamName, teamAwayName = t3.TeamName, t2.ArenaName, t1.Date, t1.Result, t1.Referee };

                foreach (var item in joinedTablesAway)
                {
                    AllFixtures tempFix = new AllFixtures();

                    tempFix.JHomeTeamName = item.teamHomeName;
                    tempFix.JAwayTeamName = item.teamAwayName;

                    tempFix.JDate = item.Date;
                    tempFix.JResult = item.Result;
                    tempFix.JReferee = item.Referee;
                    tempFix.JArena = item.ArenaName;

                    allFixtureList.Add(tempFix);
                }
            }
            // add error data to display to user
            catch
            {
                AllFixtures tempFix = new AllFixtures();

                tempFix.JHomeTeamName = "COULDNT REACH DB!";
                tempFix.JAwayTeamName = "COULDNT REACH DB!";

                tempFix.JDate = DateTime.Now;
                tempFix.JResult = "COULDNT REACH DB!";
                tempFix.JReferee = "COULDNT REACH DB!";
                tempFix.JArena = "COULDNT REACH DB!";

                allFixtureList.Add(tempFix);
            }

            List<AllFixtures> sortedFixtureLists = new List<AllFixtures>();

            // sort list
            sortedFixtureLists = allFixtureList.OrderBy(x => x.JDate).ToList();

            return View(sortedFixtureLists);
        }

        [Authorize]
        public ActionResult TopScorers()
        {
            // playerModel for league
            List<PlayerLeague> listPlayer = new List<PlayerLeague>();


            // try to give stats to each player from db
            try
            {
                // get players + team name with joins linq
                var joinedTablesPlayers = from t1 in pwdb.Players
                                          join t2 in pwdb.Teams on t1.TeamId equals t2.TeamId
                                          select new { t2.TeamName, t1.FirstName, t1.Surname, t1.Goals, t1.Assists };

                foreach (var item in joinedTablesPlayers)
                {
                    // create temp player
                    PlayerLeague tempPlayer = new PlayerLeague();

                    tempPlayer.PTeamName = item.TeamName;
                    tempPlayer.PFirstName = item.FirstName;
                    tempPlayer.PSurname = item.Surname;
                    tempPlayer.PGoals = item.Goals;
                    tempPlayer.PAssists = item.Assists;

                    listPlayer.Add(tempPlayer);
                }

            }
            // didnt work? create error model to display error
            catch
            {
                // create temp player
                PlayerLeague tempPlayer = new PlayerLeague();

                tempPlayer.PTeamName = "Error reaching DB";
                tempPlayer.PFirstName = "Error reaching DB";
                tempPlayer.PSurname = "Error reaching DB";
                tempPlayer.PGoals = 0;
                tempPlayer.PAssists = 0;

                listPlayer.Add(tempPlayer);
            }

            // add to viewmodel
            PlayerLeagueVM viewModel = new PlayerLeagueVM();

            viewModel.ListPlayers = listPlayer;

            return View(viewModel);
        }




        private bool CheckUser(string username, string password)
        {
            //LINQ method
            var anvandare = from rows in pwdb.Users
                            where rows.Username.ToUpper() == username.ToUpper()
                            && rows.Password == password
                            select rows;

            // if login worked, return true. else false
            if (anvandare.Count() == 1)
            {
                Session["user"] = 1;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}