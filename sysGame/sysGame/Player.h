#pragma once
#include "Base.h"
class Player : public Base
{

public:
	Player();
	Player:: Player(int _x, int _y, int _speed, ConsoleColor _color, const char* const _model);
	virtual ~Player();



	virtual void Render();
	virtual void Update();
};

