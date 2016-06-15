#include "stdafx.h"

#include "Game.h"



Game::Game()
{
	bool play = true;
	for (; play; )
	{
		Update();
		Render();
	}

}


Game::~Game()
{

}



void Game::Update()
{

}

void Game::Render()
{

}