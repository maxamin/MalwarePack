OBJECTS_MIPS := $(patsubst $(SRC)/%.c, $(OBJECT_OUT)/%.mips.o, $(wildcard $(SRC)/*.c))

set-mips-toolchain:
	$(eval COMPILER=$(MIPS_TOOLCHAIN)/mips-gcc)
	$(eval STRIP=$(MIPS_TOOLCHAIN)/mips-strip)

make_mips: set-mips-toolchain compile_mips

compile_mips: $(OBJECTS_MIPS)
	@echo $(TARGET).mips
	@$(COMPILER) -o $(OUT)/$(TARGET).mips  $(OBJECTS_MIPS) $(GCC_FLAGS)
	@$(STRIP) $(OUT)/$(TARGET).mips $(STRIP_FLAGS) --remove-section=.eh_frame
#	./anti_debug32 $(OUT)/$(TARGET).mips

$(OBJECTS_MIPS): $(OBJECT_OUT)/%.mips.o: $(SRC)/%.c $(HEADERS)
	@$(COMPILER) -s -Os -c $< -o $@ -D ARCH=\"mips\" -D ARCH_LEN=4 $(CFLAGS) -I $(SRC)/headers

# Done.
