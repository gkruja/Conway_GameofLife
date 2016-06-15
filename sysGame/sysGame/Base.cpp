#include "stdafx.h"
#include "Base.h"


Base::Base(int _x, int _y, int _speed, ConsoleColor _color, const char* const _model)// : speed(_speed)  <-- Member Initializer List
{
	SetSpeed(_speed);
	SetColor(_color);
	SetModel(_model);
	SetX(_x);
	SetY(_y);
}
Base::Base()
{
}


Base::~Base()
{
}



void Base::SetModel(string _model)
{
	model = _model;

	//model "viper" 0x22
	//model ----> "iiii" 0x33
	//delete[] model;

	/*int size = strlen(_model) + 1;
	model = new char[size];
	strcpy_s(model, size, _model);*/

	//model = strdup(_model);
}

void Base::Render()
{
	Console::ForegroundColor(color);
	Console::SetCursorPosition(x, y);
	cout << model;
	Console::ResetColor();
}

 void Base::Update()
{
	int dx = 0;
	int dy = 0;

	if (GetAsyncKeyState('W')) dy = -1;
	if (GetAsyncKeyState('S')) dy = 1;
	if (GetAsyncKeyState('A')) dx = -1;
	if (GetAsyncKeyState('D')) dx = 1;

	if (dx || dy)
	{
		int newx = GetX() + dx;
		SetX(newx);

		int newy = GetY() + dy;
		SetY(newy);
	}

}

void Base::WhoAmI()
{
	cout << "I am a vehicle.";
}