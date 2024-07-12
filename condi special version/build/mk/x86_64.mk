OBJECTS_X86_64 := $(patsubst $(SRC)/%.c, $(OBJECT_OUT)/%.x86_64.o, $(wildcard $(SRC)/*.c))

set-x86_64-toolchain:
	$(eval COMPILER=$(X86_64_TOOLCHAIN)/x86_64-gcc)
	$(eval STRIP=$(X86_64_TOOLCHAIN)/x86_64-strip)

make_x86_64: set-x86_64-toolchain compile_x86_64

compile_x86_64: $(OBJECTS_X86_64)
	@echo $(TARGET).x86_64
	@$(COMPILER) -o $(OUT)/$(TARGET).x86_64 $(OBJECTS_X86_64) $(GCC_FLAGS)
	@$(STRIP) $(OUT)/$(TARGET).x86_64 $(STRIP_FLAGS) --remove-section=.eh_frame
#	./anti_debug64 $(OUT)/$(TARGET).x86_64

$(OBJECTS_X86_64): $(OBJECT_OUT)/%.x86_64.o: $(SRC)/%.c $(HEADERS)
	@$(COMPILER) -s -Os -c $< -o $@ -D ARCH=\"x86_64\" -D ARCH_LEN=6 $(CFLAGS) -I $(SRC)/headers

# Done.
