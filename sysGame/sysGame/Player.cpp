#include "Utility.h"
#include "Player.h"



Player::Player()
{
}


Player::Player(int _x, int _y, int _speed, ConsoleColor _color, const char* const _model)// : speed(_speed)  <-- Member Initializer List
{
	SetSpeed(_speed);
	SetColor(_color);
	SetModel(_model);
	SetX(_x);
	SetY(_y);
}


Player::~Player()
{
}


 void  Player::Update()
{
	 bool nochange = true;
	int dx = 0;
	int dy = 0;
	if (GetAsyncKeyState('W')) dy = -1;
	if (GetAsyncKeyState('S')) dy = 1;
	if (GetAsyncKeyState('A')) dx = -1;
	if (GetAsyncKeyState('D')) dx = 1;
	

	

	if (Base::GetX() > 94)
	{
		dx = -1; nochange = false;
	}	
	if (Base::GetY() > 29)
	{
		dy = -1; nochange = false;
	}
	if (Base::GetX() < 0)
		dx = 1;
	if (Base::GetY() < 2)
	{
		dy = 0; nochange = false;
	}

	if (dx || dy && nochange)
	{
		int newx = Base::GetX() + dx;
		Base :: SetX(newx);

		int newy = Base::GetY() + dy;
		Base :: SetY(newy);
	}





}


void Player::Render()
{
	Console::ForegroundColor(Base::GetColor());
	Console::SetCursorPosition(Base::GetX(), Base::GetY());
	cout << Base:: GetName();
	Console::ResetColor();
}
