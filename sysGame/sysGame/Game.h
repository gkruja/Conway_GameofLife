#pragma once

#include "Utility.h"
#include "Base.h"
#include "Player.h"
#include "Obstacle.h"
#include "Game.h"
 class Game
{
public:
	Game();
	~Game();
	void static Run(vector<Base*>& _pop,int lbsize, char FileName[32], char PlayerName[32]);
	struct Info
	{
		char name[32];
		int score = 0;
	};

private:
	void static Update(vector<Base*>& _pop);
	void static Render(vector<Base*>& _pop);
	void static SaveFile(vector<Info>& records, char Filename[32]);
	void static OpenFile(vector<Info>& records);



};

