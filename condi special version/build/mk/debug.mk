OBJECTS_DEBUG := $(patsubst $(SRC)/%.c, $(OBJECT_OUT)/%.debug.o, $(wildcard $(SRC)/*.c))

make_debug: compile_debug

compile_debug: $(OBJECTS_DEBUG)
	@echo $(TARGET).debug
	@gcc -o $(TARGET).debug $(OBJECTS_DEBUG) -g

$(OBJECTS_DEBUG): $(OBJECT_OUT)/%.debug.o: $(SRC)/%.c $(HEADERS)
	@gcc -c $< -o $@ -D DEBUG -D ARCH=\"debug\" -D ARCH_LEN=5 $(CFLAGS) -I $(SRC)/headers

# Done.
