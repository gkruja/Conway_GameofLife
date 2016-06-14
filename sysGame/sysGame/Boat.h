#pragma once
#include "Vehicle.h"
class Boat : public Vehicle
{
private:
	int floatiness;
	string boatName;
	bool oars;
public:
	Boat() { }
	Boat(int _x, int _y, int _speed, ConsoleColor _color, const char* const _model,
		int _floatiness, const char* const _boatName, bool _oars);
	virtual ~Boat();

	int GetFloatiness() const { return floatiness; }
	const char* const GetName() const { return boatName.c_str(); }
	bool GetOars() const { return oars; }

	void SetFloatiness(int _floatiness) { floatiness = _floatiness; }
	void SetBoatName(const char* const _name) { boatName = _name; }
	void SetOars(bool _oars) { oars = _oars; }

	void WhoAmI();
	void DoBoatStuff();
};

