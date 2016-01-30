#pragma once




namespace Engine
{

	typedef struct AVCodecDescriptor {
		enum AVCodecID     id;
		enum AVMediaType type;

		const char      *name;
		const char *long_name;
		int             props;
	} AVCodecDescriptor;



	ref class MyNamesSplitterClass sealed
	{
	private:
		int _x, _y;
		Platform::String ^_name;
	public:

		MyNamesSplitterClass();

		property int X
		{
			int get()
			{
				return _x;
			}
			void set(int x)
			{
				_x = x;
			}
		}
		property Platform::String ^Name
		{
			void set(Platform::String ^N)
			{
				_name = N;
			}
			Platform::String ^get()
			{
				return _name;
			}
		}

	};
}
