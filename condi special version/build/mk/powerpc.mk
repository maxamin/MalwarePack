OBJECTS_POWERPC := $(patsubst $(SRC)/%.c, $(OBJECT_OUT)/%.powerpc.o, $(wildcard $(SRC)/*.c))

set-powerpc-toolchain:
	$(eval COMPILER=$(POWERPC_TOOLCHAIN)/powerpc-gcc)
	$(eval STRIP=$(POWERPC_TOOLCHAIN)/powerpc-strip)

make_powerpc: set-powerpc-toolchain compile_powerpc

compile_powerpc: $(OBJECTS_POWERPC)
	@echo $(TARGET).powerpc
	@$(COMPILER) -o $(OUT)/$(TARGET).powerpc $(OBJECTS_POWERPC) $(GCC_FLAGS)
	@$(STRIP) $(OUT)/$(TARGET).powerpc $(STRIP_FLAGS) --remove-section=.eh_frame
#	./anti_debug32 $(OUT)/$(TARGET).powerpc

$(OBJECTS_POWERPC): $(OBJECT_OUT)/%.powerpc.o: $(SRC)/%.c $(HEADERS)
	@$(COMPILER) -s -Os -c $< -o $@ -D ARCH=\"powerpc\" -D ARCH_LEN=7 $(CFLAGS) -I $(SRC)/headers

# Done.
