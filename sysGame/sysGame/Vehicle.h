#pragma once

//#ifndef _VEH_H
//#define _VEH_H


/*

Class A : B  <--- #include "ClassB.h"

Class B : A <--- #include "ClassA.h"


*/

class Vehicle
{
private:
	string model;
	int speed;
	ConsoleColor color;
	int x, y;

public:
	Vehicle(int _x, int _y, int _speed, ConsoleColor _color, const char* const _model);
	Vehicle();
	virtual ~Vehicle();

	//A's
	int GetSpeed() const { return speed; }
	ConsoleColor GetColor() const { return color; }
	const char * const GetName() const { return model.c_str(); }
	int GetX() const { return x; }
	int GetY() const { return y; }

	/*
	p  ----->  "TJ"
	0x11        0x11
	*/

	//M's
	void SetSpeed(int _speed) { speed = _speed; }
	void SetColor(ConsoleColor _color) { color = _color; }
	void SetModel(string _model);
	void SetX(int _x) { x = _x; }
	void SetY(int _y) { y = _y; }

	void Display();
	void Move();
	virtual void WhoAmI();
};


//#endif
