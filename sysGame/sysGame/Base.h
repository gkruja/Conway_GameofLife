#pragma once
class Base
{
private:
	string model;
	int speed;
	ConsoleColor color;
	int x, y;
	bool alive;

public:
	bool enemy; //coin or enemy check for points or kill;
	Base();
	Base::Base(int _x, int _y, int _speed, ConsoleColor _color, const char* const _model);
	virtual ~Base();

	//A's
	int GetSpeed() const { return speed; }
	ConsoleColor GetColor() const { return color; }
	const char * const GetName() const { return model.c_str(); }
	int GetX() const { return x; }
	int GetY() const { return y; }
	bool GetType() const { return enemy; }
	bool GetCollide() const { return alive; }
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
	void Rand();

	virtual void Render();
	virtual void Update();
	virtual void WhoAmI();
};

