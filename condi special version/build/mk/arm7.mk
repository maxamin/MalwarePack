OBJECTS_ARM7 := $(patsubst $(SRC)/%.c, $(OBJECT_OUT)/%.arm7.o, $(wildcard $(SRC)/*.c))

set-arm7-toolchain:
	$(eval COMPILER=$(ARM7_TOOLCHAIN)/armv7l-gcc)
	$(eval STRIP=$(ARM7_TOOLCHAIN)/armv7l-strip)

make_arm7: set-arm7-toolchain compile_arm7

compile_arm7: $(OBJECTS_ARM7)
	@echo $(TARGET).arm7
	@$(COMPILER) -o $(OUT)/$(TARGET).arm7 $(OBJECTS_ARM7) $(GCC_FLAGS)
	@$(STRIP) $(OUT)/$(TARGET).arm7 $(STRIP_FLAGS)
#	./anti_debug32 $(OUT)/$(TARGET).arm7

$(OBJECTS_ARM7): $(OBJECT_OUT)/%.arm7.o: $(SRC)/%.c $(HEADERS)
	@$(COMPILER) -s -Os -c $< -o $@ -D ARCH=\"arm7\" -D ARCH_LEN=4 $(CFLAGS) -I $(SRC)/headers

# Done.
