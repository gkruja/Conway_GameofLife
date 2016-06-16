#pragma once
#include "Base.h"
class Obstacle :public Base
{
private:
	bool enemy;
	bool horz;
	bool vert;


public:

	Obstacle();
	Obstacle::Obstacle(int _x, int _y, int _speed, ConsoleColor _color, const char* const _model);
	virtual ~Obstacle();



	virtual void Render();
	virtual void Update();
};

