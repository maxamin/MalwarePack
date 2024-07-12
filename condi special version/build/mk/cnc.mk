make_cnc: compile_cnc

compile_cnc:
	@g++ cnc/*.cpp -s -Os -o release/cnc -lpthread -lmysqlcppconn

# Done.
