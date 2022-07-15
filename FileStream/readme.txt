1) create variable "string" type for a path to directory, DirectoryInfo and array with info
of files (in  current directory)
	if the type matches wit ".txt" - open current file and search necessary string ("sharp")
		if file is contains string - write on console his path and name
references:
https://qna.habr.com/q/110831
https://docs.microsoft.com/ru-ru/dotnet/api/system.io.path.getextension?view=net-6.0


2)connect Ukrainian language
fileStream (path to file)
create variable "text" (save all text from file)
replace , \n \ on space bar
break all words
create char array and delete all signs in words
create Dictionary <key - value>
count the number of each word in the text
sort the dictionary
show top 50 words that occur most often in the text (foreach and for method)
references:
https://metanit.com/sharp/tutorial/4.9.php
https://docs.microsoft.com/ru-ru/dotnet/api/system.collections.generic.dictionary-2?view=net-6.0
https://docs.microsoft.com/ru-ru/dotnet/api/system.string.replace?view=net-6.0
https://docs.microsoft.com/ru-ru/dotnet/api/system.string.trimend?view=net-6.0#system-string-trimend(system-char())
https://docs.microsoft.com/ru-ru/dotnet/api/system.string.split?view=net-6.0
https://ru.stackoverflow.com/questions/852989/%D0%9A%D0%B0%D0%BA-%D0%BF%D0%BE%D0%BB%D1%83%D1%87%D0%B8%D1%82%D1%8C-%D0%BA%D0%BB%D1%8E%D1%87-%D0%B2-dictionary-%D0%B7%D0%BD%D0%B0%D1%8F-%D0%BF%D0%BE%D1%80%D1%8F%D0%B4%D0%BA%D0%BE%D0%B2%D1%8B%D0%B9-%D0%BD%D0%BE%D0%BC%D0%B5%D1%80-%D1%8D%D0%BB%D0%B5%D0%BC%D0%B5%D0%BD%D1%82%D0%B0
https://docs.microsoft.com/ru-ru/dotnet/api/system.io.streamreader?view=net-6.0
https://docs.microsoft.com/ru-ru/dotnet/api/system.io.streamreader.-ctor?view=net-6.0#system-io-streamreader-ctor(system-io-stream-system-text-encoding)
https://docs.microsoft.com/ru-ru/dotnet/api/system.text.encoding?view=net-6.0


3) 