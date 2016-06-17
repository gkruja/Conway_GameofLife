#pragma once

#define _h template<typename type>

template <typename type = int>
class DList
{
private:

	struct node
	{
		node* prev, *next;
		type data;

		node(type _data, node* _prev) : data(_data), prev(_prev), next(nullptr) { }
	};

	node* first, *last;
	int size;

public:
	DList();
	~DList();

	int GetSize() const { return size; }
	void push_back(type _data);
	void Push_front(type _data);
	void clear();
	void erase(int _index);


	type& operator[](int _index);
	const type& operator[](int _index) const;

};

template<typename type>
DList<type>::DList()
{
	first = last = nullptr;
	size = 0;
}

template<typename type>
DList<type>::~DList()
{

	clear();

}

_h
void DList<type>::push_back(type _data)
{
	node* n = new node(_data, last);

	if (last)
		last->next = n;
	else
		first = n;

	last = n;
	++size;
}

_h
void DList<type>::Push_front(type _data)
{
	node* n = new node(_data, first);

	if (first)
	{
		first->prev = n;
		n->next = first;
	}
	else
		last = n;

	first = n;
	
	++size;
}


_h
void DList<type>::clear()
{
	while (first)
	{
		node* t = first;
		first = first->next;
		delete t;
	}
	size = 0;
	
	
}

_h
void DList<type>::erase(int _index)
{
	node* t = first;
	node* t2 = last;
	int i = 0;
	for (; i < _index; ++i, t = t->next);




	if (t->prev == NULL)
	{
		node* t = first;
		first = first->next;
		delete t;
		size--;
	}
	else if (t->next == NULL)
	{
		node* t = last;
		last = last->prev;
		delete t;
		size--;
	}
	else if (t == NULL)
	{
		
	}
	else
	{
		t2 = t->prev;
		t2->next = t->next;
		t2 = t->next;
		t2->prev = t->prev;
		delete t;
		size--;
	}






}


template<typename type>
type& DList<type>::operator[](int _index)
{
	node* t = first;
	int i = 0;
	for (; i < _index; ++i, t = t->next);

	return t->data;
}

template<typename type>
const type& DList<type>::operator[](int _index) const
{
	node* t = first;
	int i = 0;
	for (; i < _index; ++i, t = t->next);

	return t->data;
}
