OBJECTS_X86 := $(patsubst $(SRC)/%.c, $(OBJECT_OUT)/%.x86.o, $(wildcard $(SRC)/*.c))

set-x86-toolchain:
	$(eval COMPILER=$(X86_TOOLCHAIN)/i586-gcc)
	$(eval STRIP=$(X86_TOOLCHAIN)/i586-strip)

make_x86: set-x86-toolchain compile_x86

compile_x86: $(OBJECTS_X86)
	@echo $(TARGET).x86
	@$(COMPILER) -o $(OUT)/$(TARGET).x86 $(OBJECTS_X86) $(GCC_FLAGS)
	@$(STRIP) $(OUT)/$(TARGET).x86 $(STRIP_FLAGS) --remove-section=.eh_frame -g
#	./anti_debug32 $(OUT)/$(TARGET).x86

$(OBJECTS_X86): $(OBJECT_OUT)/%.x86.o: $(SRC)/%.c $(HEADERS)
	@$(COMPILER) -s -Os -c $< -o $@ -D ARCH=\"x86\" -D ARCH_LEN=3 $(CFLAGS) -g -I $(SRC)/headers

# Done.
