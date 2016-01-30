#pragma managed(push, off)
#include <string>
struct Error
{
	explicit Error(std::string const& message) : message_(message) { }
	char const* what() const throw() { return message_.c_str(); }

private:
	std::string message_;
};