OBJECTS_SUPERH := $(patsubst $(SRC)/%.c, $(OBJECT_OUT)/%.superh.o, $(wildcard $(SRC)/*.c))

set-superh-toolchain:
	$(eval COMPILER=$(SUPERH_TOOLCHAIN)/sh4-gcc)
	$(eval STRIP=$(SUPERH_TOOLCHAIN)/sh4-strip)

make_superh: set-superh-toolchain compile_superh

compile_superh: $(OBJECTS_SUPERH)
	@echo $(TARGET).superh
	@$(COMPILER) -o $(OUT)/$(TARGET).superh $(OBJECTS_SUPERH) $(GCC_FLAGS)
	@$(STRIP) $(OUT)/$(TARGET).superh $(STRIP_FLAGS) --remove-section=.eh_frame
#	./anti_debug32 $(OUT)/$(TARGET).superh

$(OBJECTS_SUPERH): $(OBJECT_OUT)/%.superh.o: $(SRC)/%.c $(HEADERS)
	@$(COMPILER) -s -Os -c $< -o $@ -D ARCH=\"superh\" -D ARCH_LEN=6 $(CFLAGS) -I $(SRC)/headers

# Done.
