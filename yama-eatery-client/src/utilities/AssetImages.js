export const AssetImages = {
	SYSTEM_LOGO: (() => {
		try {
			return require('../assets/img/general/logo.jpg')
		} catch (e) {
			return null
		}
	})(),

	BACKGROUND: {
		HOME_HERO: (() => {
			try {
				return require('../assets/img/general/HomeHeroBackground.jpg')
			} catch (e) {
				return null
			}
		})(),
		LOGIN: (() => {
			try {
				return require('../assets/img/general/LoginBackground.jpg')
			} catch (e) {
				return null
			}
		})(),
	},

	HomeCategory: (index) => {
		try {
			return require(`../assets/img/general/HomeCategory${index}.jpg`)
		} catch (e) {
			return null
		}
	},

	HomeStandard: (index) => {
		try {
			return require(`../assets/img/general/HomeStandard${index}.jpg`)
		} catch (e) {
			return null
		}
	},

	ProductImage: (imageName) => {
		if (!imageName) return null
		try {
			return require(`../assets/img/product/${imageName}`)
		} catch (e) {
			console.warn(`Failed to load product image: ${imageName}`, e)
			return null
		}
	},

	TableImage: (imageName) => {
		if (!imageName) return null
		try {
			return require(`../assets/img/table/${imageName}`)
		} catch (e) {
			console.warn(`Failed to load table image: ${imageName}`, e)
			return null
		}
	},

	UserImage: (imageName) => {
		if (!imageName) return null
		try {
			return require(`../assets/img/user/${imageName}`)
		} catch (e) {
			console.warn(`Failed to load user image: ${imageName}`, e)
			return null
		}
	},

	VoucherImage: (imageName) => {
		if (!imageName) return null
		try {
			return require(`../assets/img/voucher/${imageName}`)
		} catch (e) {
			console.warn(`Failed to load voucher image: ${imageName}`, e)
			return null
		}
	},

	EmployeeImage: (imageName) => {
		if (!imageName) return null
		try {
			return require(`../assets/img/employee/${imageName}`)
		} catch (e) {
			console.warn(`Failed to load employee image: ${imageName}`, e)
			return null
		}
	},
}
