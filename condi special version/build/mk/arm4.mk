OBJECTS_ARM4 := $(patsubst $(SRC)/%.c, $(OBJECT_OUT)/%.arm4.o, $(wildcard $(SRC)/*.c))

set-arm4-toolchain:
	$(eval COMPILER=$(ARM4_TOOLCHAIN)/armv4l-gcc)
	$(eval STRIP=$(ARM4_TOOLCHAIN)/armv4l-strip)

make_arm4: set-arm4-toolchain compile_arm4

compile_arm4: $(OBJECTS_ARM4)
	@echo $(TARGET).arm4
	@$(COMPILER) -o $(OUT)/$(TARGET).arm4 $(OBJECTS_ARM4) $(GCC_FLAGS)
	@$(STRIP) $(OUT)/$(TARGET).arm4 $(STRIP_FLAGS) --remove-section=.eh_frame
#	./anti_debug32 $(OUT)/$(TARGET).arm4

$(OBJECTS_ARM4): $(OBJECT_OUT)/%.arm4.o: $(SRC)/%.c $(HEADERS)
	@$(COMPILER) -s -Os -c $< -o $@ -D ARCH=\"arm4\" -D ARCH_LEN=4 $(CFLAGS) -I $(SRC)/headers

# Done.
