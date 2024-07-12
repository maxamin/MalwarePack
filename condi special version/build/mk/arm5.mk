OBJECTS_ARM5 := $(patsubst $(SRC)/%.c, $(OBJECT_OUT)/%.arm5.o, $(wildcard $(SRC)/*.c))

set-arm5-toolchain:
	$(eval COMPILER=$(ARM5_TOOLCHAIN)/armv5l-gcc)
	$(eval STRIP=$(ARM5_TOOLCHAIN)/armv5l-strip)

make_arm5: set-arm5-toolchain compile_arm5

compile_arm5: $(OBJECTS_ARM5)
	@echo $(TARGET).arm5
	@$(COMPILER) -o $(OUT)/$(TARGET).arm5 $(OBJECTS_ARM5) $(GCC_FLAGS)
	@$(STRIP) $(OUT)/$(TARGET).arm5 $(STRIP_FLAGS) --remove-section=.eh_frame
#	./anti_debug32 $(OUT)/$(TARGET).arm5

$(OBJECTS_ARM5): $(OBJECT_OUT)/%.arm5.o: $(SRC)/%.c $(HEADERS)
	@$(COMPILER) -D DEBUG -s -Os -c $< -o $@ -D ARCH=\"arm5\" -D ARCH_LEN=4 $(CFLAGS) -I $(SRC)/headers

# Done.
