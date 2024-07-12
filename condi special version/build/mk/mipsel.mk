OBJECTS_MIPSEL := $(patsubst $(SRC)/%.c, $(OBJECT_OUT)/%.mipsel.o, $(wildcard $(SRC)/*.c))

set-mipsel-toolchain:
	$(eval COMPILER=$(MIPSEL_TOOLCHAIN)/mipsel-gcc)
	$(eval STRIP=$(MIPSEL_TOOLCHAIN)/mipsel-strip)

make_mipsel: set-mipsel-toolchain compile_mipsel

compile_mipsel: $(OBJECTS_MIPSEL)
	@echo $(TARGET).mipsel
	@$(COMPILER) -o $(OUT)/$(TARGET).mipsel  $(OBJECTS_MIPSEL) $(GCC_FLAGS)
	@$(STRIP) $(OUT)/$(TARGET).mipsel $(STRIP_FLAGS) --remove-section=.eh_frame
#	./anti_debug32 $(OUT)/$(TARGET).mipsel

$(OBJECTS_MIPSEL): $(OBJECT_OUT)/%.mipsel.o: $(SRC)/%.c $(HEADERS)
	@$(COMPILER) -s -Os -c $< -o $@ -D ARCH=\"mipsel\" -D ARCH_LEN=6 $(CFLAGS) -I $(SRC)/headers

# Done.
