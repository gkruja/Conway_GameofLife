#include "Utility.h"

#include "Game.h"
#include <time.h>
#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <Windows.h>
#include <mmsystem.h>
#pragma comment(lib, "Winmm.lib")

int score = 0;
bool dead = false;
int coin = 0;


Game::Game()
{

}


Game::~Game()
{

}

void Game::Run(vector<Base*>& _pop,int lbsize,char FileName[32],char PlayerName[32])
{
	ifstream fin;
	vector<Info> records;
	Info person;

	char name[32];
	Console::SetCursorPosition(20, 16);
	cout << "Enter Your Name:  ";
	cin >> name;
	fin.open("save.txt");

	//borrowed code for line counting
	int numLines = 0;
	ifstream in("save.txt");
	std::string unused;
	while (std::getline(in, unused))
		++numLines;

	if (fin.is_open())
	{
		decltype(records.size()) i = 0;
		for (; i < numLines; ++i)
		{
			fin.getline(person.name, INT_MAX, '\t');
			fin >> person.score;
			fin.ignore(INT_MAX, '\n');
			records.push_back(person);
		}

		fin.close();
	}
	bool play = true;
	int count = 0;
	bool flip=false;
	int coinspawn = 0;
	_pop.push_back(new Obstacle(0, 0, 1, Green, "$"));
	while (play)
	{
		if (GetAsyncKeyState(VK_ESCAPE))
			play = false;
		Console::Lock(true);
		system("cls");

		//draw the border and score
		
		Console::SetCursorPosition(0, 1);
		cout << "Score:" << score;
		Console::SetCursorPosition(0, 2);
		cout << "====================================================================================================";
		int i = 3;
		for ( ; i < Console::WindowHeight()-1; i++)
		{
			Console::SetCursorPosition(0, i);
			cout << '|';
			Console::SetCursorPosition(Console::WindowWidth() - 1, i);
			cout << '|';
		}
		Console::SetCursorPosition(0, Console::WindowHeight());
		cout << "====================================================================================================";

		//border drawn

		//update all the objects
		Update(_pop);
		Render(_pop);

		Console::Lock(false);
		Sleep(20);
		if (count<score)
		{
			srand(time(NULL));
			_pop.push_back(new Obstacle(0, 0, 0, Red, "V"));
			count++;
			flip = true;
		}
		if (flip)
			coinspawn++;

		if (coinspawn == 30)
		{
			flip = true;
			coinspawn = 0;
			srand(time(NULL));
			_pop.push_back(new Obstacle(0, 0, 1, Green, "$"));
		}

		if (dead)
		{
			// delete all but the player
			decltype(_pop.size()) i = 1;

			for (; i < _pop.size(); i++)
			{
				delete _pop[i];
			}
			for (i=1; i <= _pop.size()-1; i++)
			{
				 _pop.erase(_pop.begin()+1);
				 i--;
			}
			flip = false;

			coinspawn = 0;
			dead = false;

			break;
		}

	}





	
	strcpy_s(person.name, 32, name);
	person.score = score;
	records.push_back(person);



	ofstream fout;


	fout.open("save.txt");
	int size = records.size();
	if (fout.is_open())
	{
		decltype(records.size()) i = 0;
		for (; i < size ; i++)
		{
			if(i<lbsize)
			fout << records[i].name << '\t' << records[i].score ;
			if(i < size-1 )
				fout << '\n';


		}

		fout.close();
	}

	for (int i = 0; i < records.size() ; i++)
	{
		Console::SetCursorPosition(20, (5+i));
		if(i<lbsize)
		cout << records[i].name << '\t' << records[i].score;
	}

	system("pause>nul");

	score = 0;

}

void Game::Update(vector<Base*>& _pop)
{
	_pop[0]->Update();
	decltype(_pop.size()) i = 1;
	for (; i < _pop.size(); ++i)
	{
		_pop[i]->Update();

	}
}


void Game::Render(vector<Base*>& _pop)
{
	_pop[0]->Render();
	decltype(_pop.size()) i = 1;
	for (; i < _pop.size(); ++i)
	{
		if (_pop[0]->GetX() == _pop[i]->GetX() && _pop[0]->GetY() == _pop[i]->GetY())
		{
			if (_pop[i]->GetType() == false)
			{
				delete _pop[i];
				_pop.erase(_pop.begin() + i);
				score++;
			}
			else
				dead = true;
		
		}
		else if (_pop[i]->GetY() == Console::WindowHeight())
		{
			_pop[i]->SetY(3);
			_pop[i]->SetSpeed(1);

		}
		else if ( _pop[i]->GetX() == Console::WindowWidth())
		{
			_pop[i]->SetX(1);
			_pop[i]->SetSpeed(1);


		}		
		else if( _pop[i]->GetX() == 1)
		{
			_pop[i]->SetX(Console::WindowWidth()-1);
			_pop[i]->SetSpeed(-1);


		}
		else if ( _pop[i]->GetY() == 0)
		{
			_pop[i]->SetY(Console::WindowHeight());
			_pop[i]->SetSpeed(-1);
		}
		else
		{
			_pop[i]->Render();

		}



	}
}



void  Game ::SaveFile(vector<Game::Info>& records,char Filename[32])
{

}
void  Game :: OpenFile(vector<Game::Info>& records)
{

}

