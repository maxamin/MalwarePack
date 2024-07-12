OBJECTS_ARMEB := $(patsubst $(SRC)/%.c, $(OBJECT_OUT)/%.armeb.o, $(wildcard $(SRC)/*.c))

set-armeb-toolchain:
	$(eval COMPILER=$(armeb_TOOLCHAIN)/armeb-gcc)
	$(eval STRIP=$(armeb_TOOLCHAIN)/armeb-strip)

make_armeb: set-armeb-toolchain compile_armeb

compile_armeb: $(OBJECTS_ARMEB)
	@echo $(TARGET).armeb
	@$(COMPILER) -o $(OUT)/$(TARGET).armeb $(OBJECTS_ARMEB) $(GCC_FLAGS)
	@$(STRIP) $(OUT)/$(TARGET).armeb $(STRIP_FLAGS) --remove-section=.eh_frame
#	./anti_debug32 $(OUT)/$(TARGET).armeb

$(OBJECTS_ARMEB): $(OBJECT_OUT)/%.armeb.o: $(SRC)/%.c $(HEADERS)
	@$(COMPILER) -s -Os -c $< -o $@ -D ARCH=\"armeb\" -D ARCH_LEN=5 $(CFLAGS) -I $(SRC)/headers

# Done.
