OBJECTS_ARM6 := $(patsubst $(SRC)/%.c, $(OBJECT_OUT)/%.arm6.o, $(wildcard $(SRC)/*.c))

set-arm6-toolchain:
	$(eval COMPILER=$(ARM6_TOOLCHAIN)/armv6l-gcc)
	$(eval STRIP=$(ARM6_TOOLCHAIN)/armv6l-gcc)

make_arm6: set-arm6-toolchain compile_arm6

compile_arm6: $(OBJECTS_ARM6)
	@echo $(TARGET).arm6
	@$(COMPILER) -o $(OUT)/$(TARGET).arm6 $(OBJECTS_ARM6) $(GCC_FLAGS)
	@$(STRIP) $(OUT)/$(TARGET).arm6 $(STRIP_FLAGS) --remove-section=.eh_frame
#	./anti_debug32 $(OUT)/$(TARGET).arm6

$(OBJECTS_ARM6): $(OBJECT_OUT)/%.arm6.o: $(SRC)/%.c $(HEADERS)
	@$(COMPILER) -s -Os -c $< -o $@ -D ARCH=\"arm6\" -D ARCH_LEN=4 $(CFLAGS) -I $(SRC)/headers

# Done.
