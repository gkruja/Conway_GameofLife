#include "stdafx.h"
#include "Boat.h"

Boat::Boat(int _x, int _y, int _speed, ConsoleColor _color, const char* const _model,
	int _floatiness, const char* const _boatName, bool _oars) : Vehicle(_x, _y, _speed, _color, _model)
{
	SetFloatiness(_floatiness);
	SetBoatName(_boatName);
	SetOars(_oars);
}

void Boat::WhoAmI()
{
	cout << "I'm a boat. Booooat.";
}

Boat::~Boat()
{
}

void Boat::DoBoatStuff()
{
	cout << "\nI'm doin' boat stuff.";
}