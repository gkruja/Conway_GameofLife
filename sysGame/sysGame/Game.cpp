#include "Utility.h"

#include "Game.h"

int score = 0;
bool dead = false;

Game::Game()
{

}


Game::~Game()
{

}

void Game::Run(vector<Base*> _pop)
{
	bool play = true;
	int count = 0;
	while (play)
	{
		if (GetAsyncKeyState(VK_ESCAPE))
			play = false;

		Console::Lock(true);

		system("cls");

		Update(_pop);
		Render(_pop);

		Console::Lock(false);
		Sleep(10);
		count++;
		if (count < score)
		{
			delete	_pop[count];
			count += 1;

		}


	}

}

void Game::Update(vector<Base*> _pop)
{
	_pop[0]->Update();
	decltype(_pop.size()) i = 1;
	for (; i < _pop.size(); ++i)
	{
		_pop[i]->Update();
		if (_pop[i]->GetCollide())
		{
			delete _pop[i];
		}
		else
		{
			score++;						
		}
	}
}

void Game::Render(vector<Base*> _pop)
{
	_pop[0]->Render();
	decltype(_pop.size()) i = 1;
	for (; i < _pop.size(); ++i)
	{
		_pop[i]->Render();

	}
}
