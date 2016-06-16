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
	void static Run(vector<Base*>& _pop);
private:
	void static Update(vector<Base*>& _pop);
	void static Render(vector<Base*>& _pop);
};

